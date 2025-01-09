# MiniCoreApi

MiniCoreApi es una API desarrollada en ASP.NET Core que permite filtrar y calcular los gastos registrados en la base de datos según un rango de fechas ingresado por el usuario. Este proyecto está diseñado para facilitar la gestión y análisis de gastos en aplicaciones empresariales o personales.

---

## Tabla de Contenidos

1. [Características](#características)
2. [Requisitos Previos](#requisitos-previos)
3. [Instalación](#instalación)
4. [Uso](#uso)
5. [Estructura del Proyecto](#estructura-del-proyecto)
6. [Endpoints Disponibles](#endpoints-disponibles)
7. [Tecnologías Utilizadas](#tecnologías-utilizadas)
8. [Contribuciones](#contribuciones)
9. [Licencia](#licencia)

---

## Características

- Filtro de gastos según un rango de fechas especificado.
- Cálculo de gastos totales dentro del rango de fechas.
- Integración con una base de datos SQL para almacenamiento de datos.
- API RESTful, preparada para integrarse con aplicaciones front-end.

---

## Requisitos Previos

Asegúrate de tener instalado lo siguiente en tu entorno de desarrollo:

- [Visual Studio](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/).
- [.NET SDK 6.0 o superior](https://dotnet.microsoft.com/).
- [SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads) u otro sistema compatible con Entity Framework.

---

## Instalación

1. Clona este repositorio en tu máquina local:
   ```bash
   git clone https://github.com/camipaula/MiniCoreApi.git
2. Accede al directorio del proyecto:
   ```bash
   cd MiniCoreApi
3. Restaura las dependencias del proyecto ejecutando el siguiente comando en la terminal:

   ```bash
   dotnet restore
4. Configura la cadena de conexión a la base de datos en el archivo `appsettings.json`. Modifica el valor de `DefaultConnection` con los datos de tu servidor y base de datos:

   ```json
   {
       "ConnectionStrings": {
           "DefaultConnection": "Server=TU_SERVIDOR;Database=MiniCoreDB;Trusted_Connection=True;"
       }
   }
5. Ejecuta las migraciones para crear la base de datos. Utiliza el siguiente comando en la terminal:

   ```bash
   dotnet ef database update
6. Inicia el servidor ejecutando el siguiente comando en la terminal:

   ```bash
   dotnet run
7. Accede a la API desde tu navegador o una herramienta como Postman utilizando la URL predeterminada: 

   ```plaintext
   http://localhost:5000
