
# Message Queue System

This project implements a message queue system for handling user notifications, developed using ASP.NET Core and RabbitMQ.

## Features

- Send messages to a message queue.
- REST API development with ASP.NET Core.
- Message queue management using RabbitMQ.

## Installation

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) (or later)
- [RabbitMQ](https://www.rabbitmq.com/download.html) (installed and running)
- [Postman](https://www.postman.com/downloads/) (for API testing)

### Cloning the Repository

To clone the repository to your local machine, use the following command:

```bash
git clone https://github.com/harxite/Message_Queue_System.git
cd MessageQueueSystem
```

### Installing Dependencies

Install the required dependencies by running:

```bash
dotnet restore
```

### Starting RabbitMQ

Ensure that RabbitMQ is running and accessible on the default ports.

### Running the Application

To start the application, use:

```bash
dotnet run
```

Once the application is running, you can access the Swagger UI at the following URLs:

- HTTP: `http://localhost:5165/swagger`
- HTTPS: `https://localhost:7163/swagger`

## Usage

### Sending a Message

You can use Postman or a similar tool to send a request to the following API:

- **URL**: `http://localhost:5165/api/messages` (or `https://localhost:7163/api/messages` for HTTPS)
- **Method**: POST
- **Headers**:
  - `Content-Type: application/json`
- **Body** (JSON Format):

  ```json
  {
    "message": "Hello, World!"
  }
  ```

### Response

On a successful request, you will receive the following response:

```json
"Message sent to queue"
```

## API Endpoints

- `POST /api/messages` - Adds a message to the queue.

