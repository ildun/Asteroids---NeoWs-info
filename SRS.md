# Software Requirements Specification
## For "Asteroids - NeoWs info"
Version 1.0 approved

Prepared by Lyhin Illia 4.C


02.10.2022

Table of Contents
=================
  * [Introduction](introduction)
    * 1.1 [Purpose](purpose)
    * 1.2 [Document Conventions](document-conventions)
    * 1.3 [Intended Audience and Reading Suggestions](intended-audience-and-reading-suggestions)
    * 1.4 [Product Scope](product-scope)
  * [Overall Description](overall-description)
    * 2.1 [Product Perspective](product-perspective)
    * 2.2 [Product Functions](product-functions)
    * 2.3 [Operating Environment](operating-environment)
    * 2.4 [Design and Implementation Constraints](design-and-implementation-constraints)
  * [System Features](system-features)
    * 3.1 [Search for Asteroids based on their closest approach date to Earth](Search-for-Asteroids-based-on-their-closest-approach-date-to-Earth)
    * 3.2 [Browse the overall Asteroid data-set](Browse-the-overall-Asteroid-data-set)
  * [Other Nonfunctional Requirements](other-nonfunctional-requirements)
    * 4.1 [Performance Requirements](performance-requirements)
    * 4.2 [Security Requirements](security-requirements)
* [Appendix A: Glossary](appendix-a-glossary)




## 1. Introduction 
### 1.1 Purpose 

This SRS describes an application for smartphones and tablets with the Android operating system which will provide an interface for sending and receiving requests of ["Asteroids - NeoWs" NASA API](https://api.nasa.gov/). 

### 1.2 Document Conventions
Every requirement statement in this document has its own priority. This SRS document should be in "Markdown" format and follow the IEEE standard for SRS documents.

### 1.3 Intended Audience and Reading Suggestions
This document is intended for developers, users, testers, and project managers.

### 1.4 Product Scope
The purpose of this software is to provide a convenient way of using ["Asteroids - NeoWs" NASA API](https://api.nasa.gov/) using your Android smartphone. 

## Overall Description
### 2.1 Product Perspective
This project is single, has no parent projects, let alone parent SRS. The product will be an application for Android phones and tablets. Supported versions of the operating system can be found in the **2.4** section.

### 2.2 Product Functions
The application should have all the functions to perform any valid request to ["Asteroids - NeoWs" NASA API](https://api.nasa.gov/) and also receive a response and display it in the correct way. Details will be provided in Section 3.

### 2.3 Operating Environment

* Android version — 5.0 (API level 21) and higher.
* RAM — Minimum RAM of 2 GB.
* Processor modes — Qualcomm Snapdragon (version 630 and higher), Samsung Exynos, Hisilicon Kirim.

### 2.4 Design and Implementation Constraints
* SRS should be done before 2022.10.04.
* FS should be done before 2022.10.11.
* MVP should be done before 2022.10.18.


## System Features

More Functional Specifications will be provided in the FS document.
### 3.1 Search for Asteroids based on their closest approach date to Earth
Retrieve a list of Asteroids based on their closest approach date to Earth by entering starting date and end date for asteroid search, or only starting date or without parameters at all.


### 3.2 Browse the overall Asteroid data-set
Browse the overall Asteroid data-set displayed and updated by scrolling down the screen and switching pages.

## Other Nonfunctional Requirements
### 4.1 Performance Requirements
Each action through application must not cause a delay greater than 0.5 seconds on all supported platforms without taking into account NASA server delays.

### 4.2 Security Requirements
For security reasons, each time the application is launched again, it must be in the initial state and not save the results of the previous session.

## Appendix A: Glossary
1. **FS** - A functional specification in systems engineering and software development is a document that specifies the functions that a system or component must perform.
2. **IEEE** - The Institute of Electrical and Electronics Engineers Standards Association (IEEE SA) is an operating unit within IEEE that develops global standards in a broad range of industries.
3. **Markdown** - a lightweight markup language for creating formatted text using a plain-text editor. 
4. **MVP** - Minimum Viable Product - a prototype of a product, such as a software app or video game, that includes functional versions of key elements that are planned for inclusion in the final product, and that is shared with a small audience whose feedback is used to inform and direct further product development.
5. **SRS** - Software Requirements Specification - a document of a software system to be developed.

## References
* Functional Specification for "Asteroids - NeoWs info" -[https://github.com/ildun/Asteroids---NeoWs-info/blob/main/FS.md](https://github.com/ildun/Asteroids---NeoWs-info/blob/main/FS.md)
