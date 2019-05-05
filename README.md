# SOLID-Demo
Example of using DI, SRP and Generics to create a cleanly structured application

## CSVTest
The main console application entry point.

## CSVTest.Application
Contains the main program logic. This can work with any implementation of an IProcessor, this is decided by the calling code (whether that be an API or in this case a Console application.) You may notice that CSVTest.Application does not contain a reference to any implementations, only to the Contracts project. 

## CSVTest.Contracts
Contains the interfaces for the application. 

## CSVTest.Processing
Contains the implementations to perform the critical business logic. This is more or less a service.

## CSVTest.Tests
Contains some tests for the whole solution. Includes a Proof of Concept test for one of the IProcessor implementations.

## CSVTest.CrossCutting
Tools that don't fit with the main project or are applicable across all projects.
