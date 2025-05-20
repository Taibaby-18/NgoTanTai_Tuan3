# Sử dụng SDK image để build project
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Copy file dự án
COPY *.csproj ./
RUN dotnet restore

# Copy toàn bộ source code vào image
COPY . ./
RUN dotnet publish -c Release -o out

# Tạo runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/out .

# Lấy PORT từ Render
ENV ASPNETCORE_URLS=http://+:$PORT

# Chạy ứng dụng
ENTRYPOINT ["dotnet", "NgoTanTai_Tuan3.dll"]
