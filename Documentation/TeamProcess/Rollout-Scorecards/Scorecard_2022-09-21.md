# 21 September 2022 Rollout Summaries

## dotnet-helix-machines

|              Metric              |   Value  |  Target  |   Score   |
|:--------------------------------:|:--------:|:--------:|:---------:|
| Time to Rollout                  | 20:06:30 | 06:00:00 |     50     |
| Critical/blocking issues created |     0    |    0     |     0     |
| Hotfixes                         |     1    |    0     |     5     |
| Rollbacks                        |     0    |    0     |     0     |
| Service downtime                 | 00:00:00 | 00:00:00 |     0     |
| Failed to rollout                |   FALSE  |   FALSE  |     0     |
| Total                            |          |          |   **55**   |


## dotnet-helix-service

|              Metric              |   Value  |  Target  |   Score   |
|:--------------------------------:|:--------:|:--------:|:---------:|
| Time to Rollout                  | 09:16:12 | 06:00:00 |     50     |
| Critical/blocking issues created |     1    |    0     |     1     |
| Hotfixes                         |     0    |    0     |     0     |
| Rollbacks                        |     0    |    0     |     0     |
| Service downtime                 | 00:00:00 | 00:00:00 |     0     |
| Failed to rollout                |   FALSE  |   FALSE  |     0     |
| Total                            |          |          |   **51**   |

Relevant GitHub issues: [#11152](https://github.com/dotnet/arcade/issues/11152)
## arcade-services

|              Metric              |   Value  |  Target  |   Score   |
|:--------------------------------:|:--------:|:--------:|:---------:|
| Time to Rollout                  | 14:09:11 | 06:00:00 |     50     |
| Critical/blocking issues created |     1    |    0     |     1     |
| Hotfixes                         |     2    |    0     |     10     |
| Rollbacks                        |     0    |    0     |     0     |
| Service downtime                 | 00:00:00 | 00:00:00 |     0     |
| Failed to rollout                |   FALSE  |   FALSE  |     0     |
| Total                            |          |          |   **61**   |

Relevant GitHub issues: [#11050](https://github.com/dotnet/arcade/issues/11050)
# Itemized Scorecard

## dotnet-helix-machines

| Metric | [20220921.04](https://dev.azure.com/dnceng/7ea9116e-9fac-403d-b258-b31fcf1bb293/_build/results?buildId=2000111) | [20220928.02](https://dev.azure.com/dnceng/7ea9116e-9fac-403d-b258-b31fcf1bb293/_build/results?buildId=2006236) | [20220928.07](https://dev.azure.com/dnceng/7ea9116e-9fac-403d-b258-b31fcf1bb293/_build/results?buildId=2006538) | [20221005.01](https://dev.azure.com/dnceng/7ea9116e-9fac-403d-b258-b31fcf1bb293/_build/results?buildId=2012304) | [20221012.01](https://dev.azure.com/dnceng/7ea9116e-9fac-403d-b258-b31fcf1bb293/_build/results?buildId=2018261) |
|:-----:|:-----:|:-----:|:-----:|:-----:|:-----:|
| Time to Rollout | 03:12:37 | 04:28:33 | 03:03:21 | 05:37:27 | 03:44:32 |
| Critical/blocking issues created | 0 | 0 | 0 | 0 | 0 |
| Hotfixes | 0 | 0 | 1 | 0 | 0 |
| Rollbacks | 0 | 0 | 0 | 0 | 0 |
| Service downtime | 00:00:00 | 00:00:00 | 00:00:00 | 00:00:00 | 00:00:00 |


## dotnet-helix-service

| Metric | [2022092102](https://dev.azure.com/dnceng/7ea9116e-9fac-403d-b258-b31fcf1bb293/_build/results?buildId=2000178) | [2022092806](https://dev.azure.com/dnceng/7ea9116e-9fac-403d-b258-b31fcf1bb293/_build/results?buildId=2006324) | [2022100501](https://dev.azure.com/dnceng/7ea9116e-9fac-403d-b258-b31fcf1bb293/_build/results?buildId=2012399) | [2022101201](https://dev.azure.com/dnceng/7ea9116e-9fac-403d-b258-b31fcf1bb293/_build/results?buildId=2018719) |
|:-----:|:-----:|:-----:|:-----:|:-----:|
| Time to Rollout | 02:25:24 | 02:22:53 | 02:17:16 | 02:10:39 |
| Critical/blocking issues created | 1 | 0 | 0 | 0 |
| Hotfixes | 0 | 0 | 0 | 0 |
| Rollbacks | 0 | 0 | 0 | 0 |
| Service downtime | 00:00:00 | 00:00:00 | 00:00:00 | 00:00:00 |


## arcade-services

| Metric | [20220921.1](https://dev.azure.com/dnceng/7ea9116e-9fac-403d-b258-b31fcf1bb293/_build/results?buildId=2000181) | [20220928.2](https://dev.azure.com/dnceng/7ea9116e-9fac-403d-b258-b31fcf1bb293/_build/results?buildId=2006329) | [20220928.3](https://dev.azure.com/dnceng/7ea9116e-9fac-403d-b258-b31fcf1bb293/_build/results?buildId=2006775) | [20220929.3](https://dev.azure.com/dnceng/7ea9116e-9fac-403d-b258-b31fcf1bb293/_build/results?buildId=2007780) | [20221005.1](https://dev.azure.com/dnceng/7ea9116e-9fac-403d-b258-b31fcf1bb293/_build/results?buildId=2012398) | [20221012.2](https://dev.azure.com/dnceng/7ea9116e-9fac-403d-b258-b31fcf1bb293/_build/results?buildId=2018725) |
|:-----:|:-----:|:-----:|:-----:|:-----:|:-----:|:-----:|
| Time to Rollout | 02:39:10 | 02:06:25 | 02:08:00 | 02:06:53 | 02:31:07 | 02:37:36 |
| Critical/blocking issues created | 1 | 0 | 0 | 0 | 0 | 0 |
| Hotfixes | 0 | 0 | 1 | 1 | 0 | 0 |
| Rollbacks | 0 | 0 | 0 | 0 | 0 | 0 |
| Service downtime | 00:00:00 | 00:00:00 | 00:00:00 | 00:00:00 | 00:00:00 | 00:00:00 |

