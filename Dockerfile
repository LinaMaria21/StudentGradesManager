FROM mcr.microsoft.com/dotnet/sdk:10.0

WORKDIR /app

COPY . .

RUN dotnet publish -c Release -o out

ENTRYPOINT ["dotnet", "out/StudentGradeManager.dll"]