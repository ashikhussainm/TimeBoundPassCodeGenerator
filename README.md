# TimeBoundPassCodeGenerator

**Author**: Ashik M Hussain  
**Designation**: Technical Solutions Architect  
**Medium Profile**: [@ashikmhussain.a](https://medium.com/@ashikmhussain.a)

---
## Overview

A .NET 8 console application that generates time-bound passcodes based on mobile number and time window.

## Features

- Time-based passcode generation (30-minute window)
- Secure hashing with SHA-512 and SHA-384
- Modular design
- Hidden owner signature and secret

## Use Cases

This solution is ideal for environments where mobile networks are unavailable or unreliable:

- **Remote Field Operations**: Access secure applications in areas without cellular coverage.
- **Offline Secure Facilities**: Provide MFA for on-premise systems in highly secure sites.
- **Disaster Recovery Sites**: Ensure authentication works during network outages.
- **Windows Desktop Applications**: Integrate direct algorithm validation without external dependencies.
- **Backend Validation**: Any .NET 8 backend can generate and compare passcodes on-the-fly using the same algorithm, ensuring seamless offline MFA.

## Getting Started

1. Clone this repository.  
2. Navigate to the project directory:
   ```bash
   cd TimeBoundPassCodeGenerator
  ````

3. Build and run:

   ```bash
   dotnet build
   dotnet run
   ```

## Publishing

To publish to GitHub:

1. Initialize a new Git repository:

   ```bash
   git init
   git add .
   git commit -m "Initial commit of TimeBoundPassCodeGenerator"
   ```
2. Create a new repository on GitHub, then:

   ```bash
   git remote add origin https://github.com/ashikhussainm/TimeBoundPassCodeGenerator.git
   git push -u origin main
   ```

*Enjoy!*
