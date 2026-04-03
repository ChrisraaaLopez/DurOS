# DurOS - Punto de Venta

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white) ![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white) ![MYSQL](https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white) ![WINFORMS](https://img.shields.io/badge/Windows_Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white)

---

## Descripción del Proyecto

**DurOS** es una solución integral de **Punto de Venta (POS)** diseñada para optimizar la gestión comercial, el control de inventarios y la administración de transacciones en tiempo real. Este sistema fue construido enfocándose en la robustez y la integridad de los datos, garantizando que cada operación de venta sea procesada de manera eficiente y segura.

El software destaca por su implementación de una **Arquitectura en 3 Capas**, una decisión de ingeniería que separa completamente la interfaz de usuario de la lógica de negocio y el almacenamiento de datos. Este enfoque profesional facilita el mantenimiento a largo plazo y permite realizar escalabilidad de funciones sin comprometer la estabilidad global del sistema.

---

## Arquitectura del Proyecto

El núcleo de DurOS se basa en el desacoplamiento total de responsabilidades, distribuido en los siguientes módulos fundamentales:

| Capa | Responsabilidad Técnica |
| :--- | :--- |
| **📁 Presentación (DurOS)** | Capa superior que gestiona la interacción directa con el usuario mediante formularios dinámicos y controles personalizados en **Windows Forms**. |
| **📁 Manejador** | El "cerebro" del sistema. Aquí residen todas las reglas de negocio, validaciones de stock, cálculos de impuestos y orquestación de procesos lógicos. |
| **📁 Acceso a Datos** | Capa de bajo nivel encargada de la persistencia. Implementa la comunicación con el servidor **MySQL (MariaDB)** para ejecutar consultas optimizadas. |

---

## ⚙️ Especificaciones Técnicas

* **Paradigma de Programación:** Programación Orientada a Objetos (POO) con tipado fuerte.
* **Gestión de Base de Datos:** Entorno local mediante **Laragon**, garantizando un despliegue de datos rápido y confiable.
* **Diseño e Identidad:** Assets visuales diseñados profesionalmente en **Adobe Illustrator** para asegurar una interfaz coherente y moderna.
* **Entorno de Desarrollo:** Compilado bajo el ecosistema de **Visual Studio** con soporte para .NET.

---

## 📂 Organización del Repositorio

* **`DurOS/`**: Código fuente de la interfaz gráfica y componentes visuales.
* **`Manejador/`**: Clases controladoras y motores de búsqueda lógica.
* **`AccesoDatos/`**: Conexiones, mapeo de datos y transacciones SQL.
* **`resources/`**: Repositorio de recursos que incluye logotipos, isotipos y los **Scripts SQL** necesarios para la base de datos.
