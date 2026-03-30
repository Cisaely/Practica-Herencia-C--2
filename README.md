# Chimi MiBarriga - Gestión de Ventas (Sr. Billy Navaja)

Este proyecto es una aplicación de consola desarrollada en **C#** que implementa un sistema de gestión para una hamburguesería ficticia. El objetivo principal es poner en práctica los conceptos fundamentales de la **Programación Orientada a Objetos (POO)**, específicamente la **Herencia**, el **Polimorfismo** y el **Encapsulamiento**.

## Arquitectura del Sistema

El sistema utiliza una jerarquía de clases para gestionar diferentes tipos de hamburguesas con reglas de negocio específicas:

- **`Hamburguesa` (Clase Base)**: Define la estructura fundamental (Pan, Carne, Precio) y soporta hasta 4 ingredientes adicionales.
- **`HamburguesaSaludable` (Subclase)**: Especializada en pan integral y permite hasta 6 ingredientes adicionales.
- **`HamburguesaPremium` (Subclase)**: Incluye automáticamente papas y bebida, restringiendo adiciones externas para mantener la oferta de lujo.

## Características

- [x] Menú interactivo para selección de productos.
- [x] Validación dinámica de límites de ingredientes según el tipo de hamburguesa.
- [x] Desglose detallado de precios (Itemización) y cálculo de total final.
- [x] Implementación estricta de herencia en C#.

## Cómo Ejecutar (Demo en Vivo)

Para la comodidad de la evaluación, este proyecto está configurado para ejecutarse directamente en el navegador a través de **Repl.it**:

[![Run on Repl.it](https://replit.com/badge/github/TU_USUARIO_GITHUB/Herencia2)](https://replit.com/new/github/TU_USUARIO_GITHUB/Herencia2)

1. Haz clic en el botón superior (o importa este repositorio en Repl.it).
2. Presiona el botón verde **"Run"**.
3. Sigue las instrucciones interactuando con la consola.

---
*Proyecto académico realizado para practicar los fundamentos de Ingeniería de Software con C#.*
