
# Tic Tac Toe Game

## Overview

This is a simple Tic Tac Toe game developed using C#. The game allows players to compete against each other or against the computer on a 3x3 grid. The first player to align three of their symbols (either 'X' or 'O') horizontally, vertically, or diagonally wins the game.

## Features

- **Two-Player Mode:** Play with a friend in a local multiplayer setting.

- **One-Player Mode:** Play against the computer with a basic AI opponent, providing a challenging solo experience.
  
- **Automatic Move with Timer:** A timer is implemented for each player's turn. If a player does not make a move within 15 seconds, the game will automatically make a move on their behalf.
  
- **Light Mode and Dark Mode:** The game offers both Light Mode and Dark Mode to suit different player preferences. Players can switch between modes to adjust the color scheme for better visibility and comfort.
  
- **Simple Interface:** Easy-to-use interface with clear indicators for each player’s turn.
  
- **Win Detection:** Automatically detects when a player has won the game or when there’s a draw.
- **Reset Functionality:** Allows the players to reset the game and start over.

## Prerequisites

- **.NET Framework:** Ensure that you have the .NET runtime installed on your machine. You can download it from [here](https://dotnet.microsoft.com/download).

## Installation

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-friend-username/tic-tac-toe-game.git
   ```
2. **Navigate to the Project Directory:**
   ```bash
   cd tic-tac-toe-game
   ```
3. **Build the Project:**
   - Open the project in Visual Studio.
   - Build the solution by clicking on `Build > Build Solution` or pressing `Ctrl + Shift + B`.

## How to Play

1. Run the executable file generated after building the project.
2. The game window will open, showing a 3x3 grid.
3. Select the game mode: **One Player** (vs. Computer) or **Two Players** (vs. Another Player).
4. Choose between **Light Mode** or **Dark Mode** from the settings to set your preferred color theme.
5. If playing against the computer, the player takes turns with the AI clicking on the grid to place their symbol ('X' or 'O').
6. If a player does not make a move within 15 seconds, the game automatically plays a move on their behalf to keep the game flowing.
7. The first player to get three of their symbols in a row, column, or diagonal wins.
8. If the grid is filled and no player has won, the game ends in a draw.
9. Click the "Reset" button to start a new game.

## Deployment

If you want to play this game online, you can deploy it on a web server. Here's how:

1. **Convert to a Web App (if necessary):**
   - If this is a console or desktop app, consider converting it into an ASP.NET Core web app.

2. **Deploy to a Hosting Platform:**
   - Use Azure, Vercel, or another hosting service to deploy the web app version of the game.

3. **Access the Game:**
   - Once deployed, you can access the game using the provided URL in your web browser.

## Contributing

Contributions are welcome! If you have ideas for improvements or have found bugs, feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the `LICENSE` file for more details.
