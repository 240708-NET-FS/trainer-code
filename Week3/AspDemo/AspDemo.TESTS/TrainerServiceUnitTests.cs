using AspDemoApi.Data;
using AspDemoApi.DTO;
using AspDemoApi.Services;
using Moq;

namespace AspDemo.TESTS;

public class UnitTest1
{
    [Theory]
    [InlineData(1, "Kung")]
    [InlineData(2, "Kung2")]
    [InlineData(3, "Kung3")]
    public async void GetTrainerByIdGetsCorrectTrainer(int id, string name)
    {        
        //Arrange
        List<Trainer> MockTrainersList = [
            new Trainer
            {
                TrainerId = 1,
                Username = "Kung",
                Password = "Pass1"
            },
            new Trainer
            {
                TrainerId = 2,
                Username = "Kung2",
                Password = "Pass1"
            },
            new Trainer
            {
                TrainerId = 3,
                Username = "Kung3",
                Password = "Pass1"
            }
        ];

        Mock<ITrainerRepo> _trainerRepo = new();
        TrainerService trainerService = new(_trainerRepo.Object);

        //                                                          Task.FromResult is required because the original method call is async
        _trainerRepo.Setup(repo => repo.GetTrainerById(id)).Returns(Task.FromResult(MockTrainersList.FirstOrDefault(t => t.TrainerId == id)));


        //Act
        Trainer? trainer = await trainerService.GetTrainerById(id);

        //Assert
        Assert.Equal(id, trainer?.TrainerId);
        Assert.Equal(name, trainer?.Username);
    }
}