# [DevOps](https://www.atlassian.com/devops)
- CI/CD pipeline
- CI:Continuous Integration
- CD: Continuous Delivery / Continous Deployment
- Pipelines to automate build/test/deploy

- Continuous Integration
  - Rapid integration of the code
  - Build/Test new code written before being merged into the main/stable branch
- Continuous Delivery/Deployment
  - take the built artifact and deploy it to an environtment (testing/QA, dev teams env, etc)

- |---Build----|---Test----|---Release/Artifact---|---Deploy---|
- |-Continuous Integration-|
- |------------Continuous Delivery----------------|
- |--------------------Continuous Deployment-------------------|


## Building Pipelines
1. You assemble an instruction sheet on how to build/test your app (yaml)
2. Ask a virtual machine to run that instruction for you
3. ???
4. Profit

## Tools for pipelines
- Jenkins
- Azure Devops pipeline
- AWS Codebuild/codepipeline
- Github Actions