# Rubik's Cube Simulator 🧩

This project contains a full-stack implementation of a **Rubik's Cube simulator**, consisting of:

## 🖥 Backend – ASP.NET Core (C#)

- Provides the **Rubik's Cube logic**.
- Accepts rotation commands (e.g., `F`, `R'`, `U`) via HTTP API.
- Maintains and returns the cube state using a 2D exploded view grid.
- Built using **FastEndpoints** for a clean and minimal API layer.

## 🌐 Frontend – React + TypeScript + Vite

- Renders the Rubik's Cube using a **2D grid layout**.
- Interactive UI to rotate cube faces and visualize state in real-time.
- Validates input commands and sends them to the backend.
- Uses **Tailwind CSS** for styling and **Axios** for HTTP communication.

## 🚀 Technologies

| Layer     | Stack                             |
|-----------|-----------------------------------|
| Backend   | ASP.NET Core, FastEndpoints, C#   |
| Frontend  | React, TypeScript, Vite, Tailwind |
| Dev Tools | Docker, Docker Compose, pnpm      |

## 📦 Running the App

### Development

```bash
# Backend (ASP.NET Core)
cd RubikCube/RubikCube.Api
dotnet run

# Frontend (React)
cd RubikCubeUI
pnpm install
pnpm run dev
```

### Production

```bash
docker-compose -f docker-compose-prod.yaml up --build
```
