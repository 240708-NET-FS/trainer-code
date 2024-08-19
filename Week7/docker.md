# Docker
- Docker is a containerization platform that allows developers to package their application alongside with their dependencies in one convenient place/package. It allows software to be run independently of os/platform

- Virtualization vs Containerization

## Docker Concepts/Terms
- What is containerization? 
- What problem are we solving with containerization and/or virtualization?
- How is containerization different from virtualization?
- What is docker?
- What is docker engine?
- what is dockerfile?
- what is .dockerignore file?
- what is image?
- what is container?
- what is a tag?
- what is image registry?
- What is base image?

## Docker CLI Commands
- https://docs.docker.com/reference/dockerfile/

- To run local images:
    -`docker run image-name`
    - `-d` "detached" runs the container in the background
    - `-p host:container` to map container port to host machine
    - `docker run -d -p 8080:8080 aschil/snake`
    - `-i` interactive for your interactive console applications
- To see all your local images:
    - `docker image ls`
- to remove your local image
    - `docker image rm image-name-or-image-id`
- the above two commands are the same for containers as well
    - `docker container ls`
    - `docker container rm container-id`
- when in doubt, `docker resource-name --help`
- To download image from docker hub
    - `docker pull image-name`
- To upload image to docker hub
    - `docker push image-name`
- To build our image from dockerfile
    - `docker build`
    - `docker build -t dockerhubusername/imagename:tag-name relative-path-to-folder-containing-dockerfile`
    - ex: `docker build -t kunglorev/aspdemo:latest .`
- For Azure WebApp, ASPNET needs to serve over port 80
    - Include in dockerfile in the run section: `ENV ASPNETCORE_URLS=http://*:80`
- To run image locally with env variables to provide connection string:
 - docker run -d -p 12123:80 -e "ConnectionStrings:DefaultConnection=YOURCONNECTIONSTRING" kunglorev/aspdemo:0.0.1
