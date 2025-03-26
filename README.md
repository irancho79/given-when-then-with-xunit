# Password Validator Project

This project demonstrates the use of the Given-When-Then format for Behavior-Driven Development (BDD) testing. The Password Validator project includes multiple versions of password validation logic and their respective test cases.

## Project Overview

The project is organized into different versions of the Password Validator, each with its own set of test cases. The tests are written using the Given-When-Then format to clearly define the conditions, actions, and expected outcomes.

### Password Validator Versions

- **Version 1**: Basic password validation.
- **Version 2**: Enhanced validation with additional criteria.
- **Version 3**: Validation for different user types (Admin, Guest, Standard).
- **Version 4**: Separate validators for Admin, Guest, and Standard users.
- **Version 5**: Given-When-Then scenarios for different user types.

## Given-When-Then Scenarios

### Admin User

#### Scenario: Password Lacks Special Character
- **Given** an admin user
- **When** the password lacks a special character
- **Then** validation should fail

#### Scenario: Password Meets Criteria
- **Given** an admin user
- **When** the password meets all criteria
- **Then** validation should pass

### Guest User

#### Scenario: Password Is Long Enough
- **Given** a guest user
- **When** the password is long enough
- **Then** validation should pass

### Standard User

#### Scenario: Password Is Too Short
- **Given** a standard user
- **When** the password is too short
- **Then** validation should fail

#### Scenario: Password Meets Criteria
- **Given** a standard user
- **When** the password meets all criteria
- **Then** validation should pass

## Running the Tests

To run the tests, ensure you have the following prerequisites:

- C# version: 12.0
- .NET target: .NET 8

Use the following command to run the tests:

