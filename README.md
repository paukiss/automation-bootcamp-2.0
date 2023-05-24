# Tests de Automatización en C#

Este repositorio contiene un código en C# para realizar pruebas de automatización en dos páginas web diferentes [todoist](https://todoist.com/) y [yopmail](https://yopmail.com/). 

El objetivo es proporcionar un ejemplo básico de cómo estructurar y ejecutar pruebas automatizadas utilizando el lenguaje de programación C# y algunas herramientas populares de automatización web.

## Requisitos

Antes de comenzar, asegúrate de tener instalado lo siguiente:

- [Visual Studio](https://visualstudio.microsoft.com/) o algún otro entorno de desarrollo integrado (IDE) para C#.
- [Selenium WebDriver](https://www.selenium.dev/documentation/en/webdriver/) para interactuar con los elementos de las páginas web.
- [ChromeDriver](https://chromedriver.chromium.org/downloads) para manejar automáticamente la descarga y configuración del controlador (driver) del navegador web.

## Estructura del proyecto

El proyecto se organiza de la siguiente manera:

```
src
├── code
│   ├── browser
│   ├── control
│   ├── page
│   ├── session
│   └── test
│       ├── todoist
│       │   └── ProjectTest.cs
│       └── yopmail
│           └── SendAndCheckEmailTest.cs
└── resources
    └── driver
        └── chromedriver.exe
```
- `src`
  - `code`
    - `test`: 
      - `todoist`: Pruebas de automatizacion para CRUD de proyecto en la aplicación Todoist.
      - `yopmail`: Pruebas de la aplicación YopMail.
  - `resources`: 
    - `driver`: Directorio para almacenar los controladores de los navegadores web utilizados en las pruebas.

## Configuración

Antes de ejecutar las pruebas, es necesario configurar el proyecto. Asegúrate de seguir los siguientes pasos:

1. Clona o descarga este repositorio en tu máquina local.
2. Abre el proyecto en tu IDE de preferencia (por ejemplo, Visual Studio).
3. Asegúrate de que las dependencias necesarias (Selenium WebDriver) estén instaladas en tu proyecto. 

## Ejecución de las pruebas

Una vez configurado el proyecto, puedes ejecutar las pruebas de automatización. Sigue estos pasos:

1. Abre el archivo `ProjectTest.cs` y/o `SendAndCheckEmailTest.cs` según qué página deseas probar.
2. Ejecuta las pruebas utilizando el IDE.

¡Automatizar es divertido! 🚀