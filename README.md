# ConsumoApi

Proyecto .NET MAUI (Blazor) para consumir una API REST. Esta aplicación (target .NET 10) permite listar, crear, modificar y eliminar productos usando un servicio remoto (fakestoreapi.com por defecto).

Características principales
- Interfaz construida con .NET MAUI y Blazor WebView.
- Consumo de endpoints REST para operaciones CRUD sobre productos.
- Páginas Razor para listado, alta y edición de productos.

Requisitos
- .NET 10 SDK
- Visual Studio 2022/2026 con la carga de trabajo ".NET MAUI" instalada (o VS Code con las extensiones necesarias)

Instalación
1. Clona el repositorio:

   git clone https://github.com/juliancarola04/CRUD-API-ProgramacionMovil.git
   cd ConsumoApi

2. Restaura dependencias y compila:

   dotnet restore
   dotnet build -c Debug

Ejecución
- Ejecutar en la máquina de desarrollo:

  dotnet build -c Debug
  dotnet run --project ConsumoApi/ConsumoApi.csproj

- Para dispositivos móviles o emuladores, abre la solución en Visual Studio y selecciona el dispositivo objetivo.

API base
- La URL base utilizada por HttpClient está configurada en: ConsumoApi/MauiProgram.cs
  - Por defecto: https://fakestoreapi.com/
  - Cambiarla editando la instancia HttpClient registrada en MauiProgram.cs si quieres apuntar a otra API.

Páginas y endpoints

- ListaProductos
  - Ruta: /listaProductos
  - Archivo: ConsumoApi/Components/Pages/ListaProductos.razor
  - Descripción: Muestra la lista de productos en tarjetas; permite navegar para modificar o agregar y eliminar.
  - Endpoints consumidos (base: https://fakestoreapi.com/):
	- GET products  -> Recupera todos los productos
	- DELETE products/{id} -> Elimina un producto por id

- AgregarProducto
  - Ruta: /agregarproducto
  - Archivo: ConsumoApi/Components/Pages/AgregarProducto.razor
  - Descripción: Formulario para crear un nuevo producto.
  - Endpoints consumidos (base: https://fakestoreapi.com/):
	- POST products -> Crea un nuevo producto (envía el objeto Producto en JSON)

- ModificarProducto
  - Ruta: /modificarproducto/{Id:int?}
  - Archivo: ConsumoApi/Components/Pages/ModificarProducto.razor
  - Descripción: Carga un producto por id, permite editar y guardar cambios.
  - Endpoints consumidos (base: https://fakestoreapi.com/):
	- GET products/{id} -> Recupera un producto por id
	- PUT products/{id} -> Actualiza un producto por id (envía el objeto Producto en JSON)

Modelos
- Producto (ConsumoApi/Models/Producto.cs)
  - id: int
  - title: string (required)
  - price: float (required)
  - description: string
  - category: string
  - image: string
  - rating: Rating (objeto con rate, count)

Licencia
- Usalo como quieras!!!
