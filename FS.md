# Functional Specification
## For "Asteroids - NeoWs info"

Version 1.0 approved  
Prepared by Lyhin Illia  
 
08.10.2022

Table of Contents
================
* 1 [Introduction](introduction)
   * 1.1 [Document Purpose](document-purpose)
   * 1.2 [Intended Audience](Intended-Audience)
* 2 [Scenarios](scenarios)
   * 2.1 [Usecases](usecases)
   * 2.2 [Personas](personas)
   * 2.3 [Product Scope](product-scope)
   * 2.4 [Unimportant Functions](unimportant-functions)
* 3 [Architecture Overview](architecture-overview)
   * 3.1 [Work Flow](work-flow)
   * 3.2 [Tab 1: Search for Asteroids based on their closest approach date to Earth](tab1)
   * 3.3 [Tab 2: Browse the overall Asteroid data-set](tab2)
* [References](references)

## 1. Introduction  
### 1.1 Document Purpose
  This Functional Specification document describes all functions and interfaces that the product will have the purpose of this document is to present a description of the functions and interfaces of the final product. 
### 1.2 Intended Audience
This document is intended for developers and testers.

## 2. Scenarios
### 2.1 Usecases
The functions of this app can be useful in searching for Asteroids based on their closest approach date to Earth or browsing the overall NASA Asteroid data set.
### 2.2 Personas
The main users of the product will be students, scientists, and all those who may need application functions
 
### 2.3 Product Scope
The purpose of this software is to provide convenient access to Asteroids - NeoWs NASA API. 

### 2.4 Unimportant Functions
The history of the last requests to NASA API is not important and may not be implemented. 

## 3. Architecture Overview
### 3.1 Work Flow
When an application is opened, it should always be in the initial state and running NeoFeed activity, that has functions for input parameters for the request to search for Asteroids based on their closest approach date to the Earth. But the user does not have to execute this request specifically, he can switch to the next tab to execute another request for browsing the overall NASA Asteroid data set.
The data flow is shown in the next picture:

<p align="center">
  <img src="https://github.com/ildun/Asteroids---NeoWs-info/blob/9eaf600efee4e6cbb010a61ab517788626da4bc3/InformationFlow.jpg" />
</p>

### 3.2 Tab 1: Search for Asteroids based on their closest approach date to Earth
This activity will contain two buttons: one for editing parameters and one for sending a request. The response will be displayed in the same activity below the buttons.
Users can input the **start date** parameter and **end date** parameter or input only the **start date** parameter or request without input at all (in that case it should be a request for most updated information). If the user will input only the **start date** parameter, then the **end date** parameter will be automatically set to 7 days after the **start date**.

The possible user interface is shown in the next picture:

<p align="center">
  <img src="https://github.com/ildun/Asteroids---NeoWs-info/blob/a18605aed6c96f6338e59e17aba7bc72f02bdf8f/NeoFeed_UIexample.jpg" style="width:200px;" />
</p>
  

### 3.3 Tab 2: Browse the overall Asteroid data-set
This activity will contain three buttons (**GO**, **PREV**, and **NEXT**) to switch pages of the overall Asteroid data set. 
The possible user interface is shown in the next picture:

<p align="center">
  <img src="https://github.com/ildun/Asteroids---NeoWs-info/blob/a18605aed6c96f6338e59e17aba7bc72f02bdf8f/Browse_UIexample.jpg" style="width:200px;"/>
</p>
  
  
## References
* Software Requirement Specification for "Asteroids - NeoWs info" -[https://github.com/ildun/Asteroids---NeoWs-info/blob/main/SRS.md](https://github.com/ildun/Asteroids---NeoWs-info/blob/main/SRS.md)
* Asteroids - NeoWs NASA API - [https://api.nasa.gov/](https://api.nasa.gov/)
