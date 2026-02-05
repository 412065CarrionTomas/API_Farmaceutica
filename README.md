📘 API Farmacéutica

API REST para la gestión de una farmacia, desarrollada en ASP.NET Core con una arquitectura moderna y limpia.

Este proyecto forma parte de mi portafolio técnico y demuestra diseño de software, uso de patrones y buenas prácticas aplicadas en un backend real.

🧩 Patrones de diseño:

Este proyecto implementa varios patrones con el objetivo de lograr un código predecible, mantenible y fácil de extender:

Repository Pattern: 
Se utiliza para abstraer el acceso a datos y desacoplar la lógica de negocio de los detalles de persistencia.
Esto permite cambiar la fuente de datos sin afectar los casos de uso y mejora la testabilidad.

REPR (Request · Evaluate · Process · Respond): 
Cada caso de uso sigue un flujo claro y explícito:

Request: recepción y modelado de la entrada.

Evaluate: validaciones y preparación de la operación.

Process: ejecución de la lógica principal.

Respond: construcción de la respuesta.
Este patrón aporta claridad, orden y coherencia a cada feature.

Railway Oriented Programming
La lógica se estructura para manejar los flujos exitosos y de error de forma explícita, evitando estados intermedios ambiguos y favoreciendo un código más seguro y legible.

🏗️ Arquitectura

Vertical Slice Architecture (VSA)
La aplicación está organizada por features o casos de uso, donde cada slice contiene todo lo necesario para resolver una funcionalidad específica (request, handler, response, lógica y dependencias).
Este enfoque reduce el acoplamiento entre funcionalidades y facilita la evolución del sistema.

Enfoque híbrido con Clean Architecture
Si bien el eje principal es la Vertical Slice Architecture, el proyecto incorpora conceptos clave de Clean Architecture, como:

Inversión de dependencias.

Separación entre dominio, aplicación e infraestructura.

Uso de interfaces para aislar detalles técnicos.

Esta combinación permite aprovechar lo mejor de ambos enfoques, logrando una arquitectura flexible, clara y preparada para escalar.

📐 Principios de diseño aplicados

Single Responsibility: Cada clase hace una cosa y bien.

Separation of Concerns: Separación entre API, lógica de dominio y acceso a datos.

Dependency Injection: Uso de DI para repositorios, mappers y servicios.

Repository Pattern: Abstracción de acceso a datos a través de interfaces.

DTOs y AutoMapper: Para manejar mapeos entre modelos de dominio y datos de entrada/salida.
