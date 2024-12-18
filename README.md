# DomotiLab
![Static Badge](https://img.shields.io/badge/develop%20with-.NET%208%20C%23-green?logo=dotnet)
![Static Badge](https://img.shields.io/badge/enviroment-docker-%232496ED?logo=docker)
![Static Badge](https://img.shields.io/badge/database-PostgreSQL-%234169E1?logo=postgresql)
![Static Badge](https://img.shields.io/badge/status-develop-green)
![GitHub License](https://img.shields.io/github/license/RublenX/DomotiLab)
![GitHub Release](https://img.shields.io/github/v/release/RublenX/DomotiLab)

## Descripción
Proyecto personal para crear un sistema domótico que controle los dispositivos y su gestión.

Es una iniciativa personal para crear un sistema de microservicios sencillo utilizando las buenas prácticas de desarrollo.

## Índice

- [Estado del proyecto](#estado-del-proyecto)
- [Instalación y Uso](#instalación-y-uso)
- [Tecnologías Aplicadas](#tecnologías-aplicadas)
- [Créditos](#créditos)
- [Licencia](#licencia)
- [Funcionalidad](#funcionalidad)

## Estado del proyecto
🚧 Proyecto en construcción 🚧

Se utilizan [Badges](https://shields.io/) en la cabecera del documento para indicar el estado del proyecto. Estos badges son muy útiles para mostrar información relevante de tu proyecto de forma visual y atractiva. Puedes personalizarlos según tus necesidades y preferencias. 😊

## Instalación y Uso
Lo que se necesita para instalar el proyecto (pre-requisitos) en el entorno de desarrollo y poder utilizarlo adecuadamente.

Cómo lanzarlo y ejemplo de pruebas.

🚧 POR DEFINIR 🚧

Cómo y dónde desplegarlo

🚧 POR DEFINIR 🚧

## Tecnologías Aplicadas
🚧 POR DEFINIR 🚧

Frameworks, repositorios, arquitectura, buenas prácticas, etc.

Este proyecto intenta aprender e interiorizar las recomendaciones y buenas prácticas expuestas en el libro [".NET Microservices: Arqchitecture for Containerized .NET Applications"](https://learn.microsoft.com/es-es/dotnet/architecture/microservices/).
Existe un proyecto ejemplo creado por los autores del libro en [GitHub](https://github.com/dotnet/eShop).

Otros sitios donde se habla de Microservicios:
- [Microservicios con contenedores de .NET y Docker](https://dotnet.microsoft.com/es-es/apps/aspnet/microservices)
- [Guías de arquitectura de aplicaciones .NET](https://dotnet.microsoft.com/es-es/learn/dotnet/architecture-guides)
- [Azure Architecture Center](https://learn.microsoft.com/es-es/azure/architecture/?source=docs)
- [Marco de arquitectura de Azure](https://learn.microsoft.com/es-es/azure/well-architected/)
- [Arquitectura de microservicios en Azure Kubernetes Service](https://learn.microsoft.com/es-es/azure/architecture/reference-architectures/containers/aks-microservices/aks-microservices)

### CodeFirst
Esta solución aplica el acercamiento de 'CodeFirst' para la creación y gestión de base de datos.


## Créditos
Colaboradores, librerías de terceros, documentación de referencia y cómo poder contribuir, si se da el caso.

## Licencia
[Creative Commons Zero (CC0)](https://creativecommons.org/publicdomain/zero/1.0/)

## Funcionalidad
Inicialmente existen dos proyectos.

El primero gestiona los dispositivos electrónicos que pueden conectarse a la red con sus características principales.

El segundo proyecto se encarga de recopilar la información de la red y asociarla a los dispositivos electrónicos registrados.

## Estructura de Carpetas
Organizar adecuadamente tu proyecto .NET en GitHub puede facilitar la navegación y mantenimiento del código. Una posible estructura de carpetas recomendada para un proyecto .NET sería la siguiente:

```
/DomotiLab
    /src
        /Dispositivos.WebApi
            Controllers/
            Dispositivos.WebApi.csproj
        /RedLocal.WebApi
            Controllers/
            RedLocal.WebApi.csproj
    /docs
    /tools
    /build
    .gitignore
    README.md
    LICENSE.md
```

- **src/**: Aquí irán el código fuente del proyecto y los archivos relacionados.
- **docs/**: Documentación del proyecto.
- **tools/**: Scripts y herramientas útiles.
- **build/**: Archivos y configuraciones relacionadas con el proceso de construcción.
- **.gitignore**: Archivo para excluir archivos innecesarios del repositorio.
- **README.md**: Descripción general del proyecto.
- **LICENSE**: Licencia del proyecto.

Esta estructura permite mantener un orden lógico y facilita el acceso a diferentes partes del proyecto, además de separar claramente el código fuente, las pruebas, y otros recursos.
