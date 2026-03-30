@echo off
setlocal
title Chimi MiBarriga - Ejecutor de Billy Navaja

echo ==========================================
echo    Chimi MiBarriga - Billy Navaja
echo ==========================================
echo.

:: Verificar si dotnet está instalado
dotnet --version >nul 2>&1
if %errorlevel% neq 0 (
    echo [ERROR] No se ha encontrado el SDK de .NET instalado.
    echo Por favor, descárgalo e instálalo desde: https://dotnet.microsoft.com/download
    pause
    exit /b %errorlevel%
)

echo [INFO] Compilando el proyecto...
dotnet build --verbosity quiet
if %errorlevel% neq 0 (
    echo [ERROR] Hubo un problema al compilar el proyecto. Verifica errores de sintaxis.
    pause
    exit /b %errorlevel%
)

echo [INFO] Ejecutando ChimiApp...
echo.
dotnet run --no-build
echo.
echo ==========================================
echo [INFO] Ejecución finalizada.
pause
