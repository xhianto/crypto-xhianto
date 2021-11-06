# crypto-xhianto

crypto-xhianto created by Ka Hea Lam

## Requirements

- Git
- Docker

## How to use this repository

Pull this repository with
````
git clone https://github.com/EHB-TI/crypto-xhianto
````
Change your directory to the same level of the docker file, usually
````
cd crypto-xhianto
````
Build the Docker image ***(Do not forget the . at the end)***
````
docker build -t <name> .
````
*\<name\> = Name of your choice*  
  
Run the application with the following command
````
docker run -d -p <port>:80 <name>
````
*\<port\> = port to run application on*  
*\<name\> = name of image at previous step*
  
The appliction should be running, you should be able to check it on a web-browser
````
http://localhost:<port>
````
*\<port\> = port at previous step*

## Location of codes

Most of the codes are located in the controller  
*crypto-xhianto/Cryptografie/Controllers/HomeController.cs*  
Models are in the directory  
*crypto-xhianto/Cryptografie/Models/*  
Views are locate at  
*crypto-xhianto/Cryptografie/Views/Home/*

## Website

This appliction is also hosted on Azure.  
[https://cryptografie.azurewebsites.net/](https://cryptografie.azurewebsites.net/)
