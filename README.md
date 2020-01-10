# RepoMage
This is a helper utility thats designed to help archive old repos that are no longer in use.

| Environment | Status |
| ------------- |:-------------:|
| Master        | [![Build Status](https://travis-ci.com/lareeth/RepoMage.svg?branch=master)](https://travis-ci.com/lareeth/RepoMage) |
| Dev           | [![Build Status](https://travis-ci.com/lareeth/RepoMage.svg?branch=dev)](https://travis-ci.com/lareeth/RepoMage) |

### Running docker image
There is a prebuilt image that is available [https://hub.docker.com/r/lareeth/repomage](https://hub.docker.com/r/lareeth/repomage) and can run with the following command

```
docker run -v $PWD/settings.json:/opt/app/settings.json:ro lareeth/repomage
```

### Building local docker image
This has been designed so you do not need dotnet core installed on your local machine
```
docker build -t repomage .
```

### License
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Flareeth%2FRepoMage.svg?type=large)](https://app.fossa.io/projects/git%2Bgithub.com%2Flareeth%2FRepoMage?ref=badge_large)