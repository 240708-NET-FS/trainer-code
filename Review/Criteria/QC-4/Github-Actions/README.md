# Github Actions

|  Difficulty |  Criteria                                                                                                             |
| ------------------- | ------------------------------------------------------------------------------------------------------------------------- |
| Must Have           | Use the "workflow_dispatch" keyword to manually trigger a workflow.                                                       |
| Must Have           | Create a workflow by writing a YAML file in the .github/workflows directory on the repository that builds an application. |
| Must Have           | Use "secrets" to store credentials and other sensitive information                                                        |
| Must Have           | Explain the relationships between "triggers", "jobs" and "steps."                                                         |
| Must Have           | Create a workflow that uses a static analysis tool to scan code for defects.                                              |
| Must Have           | Read and understand workflow run logs to debug a failed workflow.                                                         |
| Should Have         | Use built in triggers to automatically run workflows based on repository events.                                          |
| Should Have         | Use a testing step to automatically run unit tests as part of a workflow.                                                 |
| Should Have         | Create a sequential multi-job workflow that passes artifacts from one job to another.                                     |
| Advanced        | Create workflow that calls other workflows.                                                                               |
| Advanced        | Utilize conditions to control job execution within a workflow.                                                            |
| Advanced        | Use triggers to run branch specific workflows that target different environments.                                         |
| Advanced        | Create a workflow that commits output artifacts to the repository for future reuse/review.                                |
| Advanced        | Use dependency caching to speed up future workflow runs.                                                                  |
