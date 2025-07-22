# Use lightweight IIS base image
FROM mcr.microsoft.com/windows/servercore/iis:windowsservercore-ltsc2022

# Enable ASP.NET support
RUN dism /online /enable-feature /all /featurename:IIS-ASPNET45 /NoRestart

# Set working directory
WORKDIR /inetpub/wwwroot

# Clear the default IIS site
RUN powershell -Command "Remove-Item -Recurse -Force *"

# Copy published files (this should be your Visual Studio 'publish' output)
COPY ./publish/ .

# (Optional) Expose a custom port (change if needed)
EXPOSE 80

# Start IIS
ENTRYPOINT ["C:\\ServiceMonitor.exe", "w3svc"]