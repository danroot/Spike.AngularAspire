To run in VSCode:
- run `sudo npm install` in the angular project directory
- launch Spike.AngularAspire.AppHost in VSCode

To run in CLI
- run `sudo npm install` in the angular project directory
- run `dotnet run` in the AppHost directory

To reproduce the issue:
- run the app and confirm the Aspire dashboard is running
- Confirm the angular app is running by navigating to `https://localhost:44312/` in a browser
- Open Activity Monitor and observe a 'ng serve' process running
- Click stop in the Aspire dashboard next to the resource for the angular app
- Observe the 'ng serve' process is still running in Activity Monitor
- Stop the app host by clicking the stop button in vscode or Ctrl+C in the terminal
- Observe the 'ng serve' process is still running in Activity Monitor

Expected behavior:
- When the angular app is stopped in the Aspire dashboard, the 'ng serve' process should also stop
- When the app host is stopped, the 'ng serve' process should also stop

