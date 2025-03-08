# Gestión de Productos

Este repositorio contiene una aplicación de Windows Forms desarrollada en C# con .NET Framework 4.7/4.8 para la **gestión de productos**. Este proyecto fue realizado como parte del examen supletorio de la asignatura **Programación Estructurada y Visual** en el Instituto Superior Tecnológico “Compu Sur”.

## Funcionalidades

La aplicación permite realizar las siguientes operaciones:
1. **Mostrar Productos:** Visualiza todos los productos registrados en un ListBox con información descriptiva (Código, Nombre, Precio y Cantidad).
2. **Introducir Producto:** Agrega un nuevo producto solicitando código, nombre, precio y cantidad. No se permiten duplicados en el código.
3. **Eliminar Producto:** Elimina un producto a partir de su código.
4. **Consultar Producto:** Muestra la información completa de un producto específico.
5. **Modificar Precio:** Actualiza el precio de un producto seleccionado.
6. **Mostrar Productos en Stock:** Filtra y muestra los productos que tienen cantidad mayor a cero.
7. **Mostrar Productos Agotados:** Filtra y muestra los productos cuyo stock es igual a cero.
8. **Mostrar Productos en Oferta:** Filtra y muestra los productos cuyo precio es menor a un valor específico (por ejemplo, 10).
9. **Modificar Cantidad:** Permite actualizar la cantidad disponible de un producto.

## Estructura del Proyecto

El proyecto está organizado de la siguiente forma:

- **IProducto.cs:** Define la interfaz con las propiedades básicas del producto.
- **ProductoBase.cs:** Clase abstracta que establece la estructura base de un producto (utilizando herencia).
- **Producto.cs:** Clase concreta que hereda de `ProductoBase` e implementa la funcionalidad específica del producto. Su método `ToString()` se ha modificado para mostrar la información de forma descriptiva.
- **Inventario.cs:** Clase que administra el inventario de productos y contiene los métodos para agregar, eliminar, consultar, modificar y filtrar productos.
- **Form1.cs:** Interfaz gráfica (Windows Forms) donde se gestionan los eventos y se conectan los controles con la lógica de negocio.
- **Program.cs:** Archivo principal que inicia la aplicación de Windows Forms.

## Requisitos

- **Visual Studio** (cualquier versión que soporte Windows Forms y .NET Framework 4.7/4.8).
- **.NET Framework 4.7 o 4.8** instalado en el sistema.

## Instrucciones para Ejecutar

**Clonar el Repositorio:**

   ```bash
   git clone https://github.com/IvanVY/GestionProductos.git
```
   ## Abrir el Proyecto

1. Abre **Visual Studio**.
2. Selecciona **Abrir un proyecto o solución** y navega a la carpeta donde clonaste el repositorio.
3. Abre el archivo `GestionProductos.sln`.

## Compilar y Ejecutar

1. Compila el proyecto (por ejemplo, con `Ctrl + Shift + B`) para asegurarte de que no haya errores.
2. Ejecuta la aplicación (`F5`) y prueba cada funcionalidad.

## Uso de la Aplicación

- **Ingreso de Datos:** Completa los campos de texto para código, nombre, precio y cantidad.
- **Visualización:** El ListBox mostrará cada producto con la información completa de forma descriptiva, por ejemplo:
Código: 001 | Nombre: Teclado | Precio: 15.5 | Cantidad: 10

- **Limpieza de Campos:** Después de cada acción (agregar, eliminar, modificar, consultar), los campos de entrada se limpian automáticamente para facilitar el ingreso de nuevos datos.
