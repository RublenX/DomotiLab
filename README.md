# DomotiLab

## Descripción
Proyecto personal para crear un sistema domótico que controle los dispositivos y su gestión.

Es una iniciativa personal para crear un sistema de microservicios sencillo utilizando las buenas prácticas de desarrollo.

## Índice

- [Estado del proyecto](#estado-del-proyecto)]

## Estado del proyecto
🚧 Proyecto en construcción 🚧
Se pueden utiliza también [Badges](https://shields.io/)

![Badge EnDesarrollo](https://img.shields.io/badge/STATUS-EN%20DESAROLLO-green)

![GitHub Release](https://img.shields.io/github/v/release/RublenX/DomotiLab)



## Instalación y Uso
Lo que se necesita para instalar el proyecto (pre-requisitos) en el entorno de desarrollo y poder utilizarlo adecuadamente.

Cómo lanzarlo y ejemplo de pruebas.

Cómo y dónde desplegarlo

## Tecnologías Aplicadas
Frameworks, repositorios, arquitectura, buenas prácticas, etc.

Este proyecto intenta aprender e interiorizar las recomendaciones y buenas prácticas expuestas en el libro [".NET Microservices: Arqchitecture for Containerized .NET Applications"](https://learn.microsoft.com/es-es/dotnet/architecture/microservices/).
Existe un proyecto ejemplo creado por los autores del libro en [GitHub](https://github.com/dotnet/eShop).

### CodeFirst
Esta solución aplica el acercamiento de 'CodeFirst' para la creación y gestión de base de datos.


## Créditos
Colaboradores, librerías de terceros, documentación de referencia y cómo poder contribuir, si se da el caso.

## Licencia
Si la tiene

## Funcionalidad
La funcionalidad básica que realiza el proyecto

## Estructura de Carpetas
Organizar adecuadamente tu proyecto .NET en GitHub puede facilitar la navegación y mantenimiento del código. Aquí te dejo una estructura de carpetas recomendada para un proyecto .NET típico:

```
/MyProject
    /src
        /MyProject
            Controllers/
            Models/
            Views/
            wwwroot/
            MyProject.csproj
        /MyProject.Tests
            UnitTests/
            IntegrationTests/
            MyProject.Tests.csproj
    /docs
    /tools
    /build
    .gitignore
    README.md
    LICENSE
    build.sh
    build.ps1
```

- **src/**: Aquí irán el código fuente del proyecto y los archivos relacionados.
  - **MyProject/**: Contiene los archivos y carpetas específicos del proyecto.
    - **Controllers/**: Controladores del MVC.
    - **Models/**: Modelos del MVC.
    - **Views/**: Vistas del MVC.
    - **wwwroot/**: Archivos estáticos como JavaScript, CSS, e imágenes.
    - **MyProject.csproj**: Archivo del proyecto .NET Core.
  - **MyProject.Tests/**: Proyecto de pruebas.
    - **UnitTests/**: Pruebas unitarias.
    - **IntegrationTests/**: Pruebas de integración.
    - **MyProject.Tests.csproj**: Archivo del proyecto de pruebas.

- **docs/**: Documentación del proyecto.
- **tools/**: Scripts y herramientas útiles.
- **build/**: Archivos y configuraciones relacionadas con el proceso de construcción.
- **.gitignore**: Archivo para excluir archivos innecesarios del repositorio.
- **README.md**: Descripción general del proyecto.
- **LICENSE**: Licencia del proyecto.
- **build.sh** y **build.ps1**: Scripts para construir el proyecto en diferentes sistemas operativos.

Esta estructura permite mantener un orden lógico y facilita el acceso a diferentes partes del proyecto, además de separar claramente el código fuente, las pruebas, y otros recursos. Si tienes algún componente adicional en tu proyecto, puedes agregar más carpetas o ajustar esta estructura según tus necesidades. 😊

¿Hay algo más en lo que te pueda ayudar?
