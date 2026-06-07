# 🔍 Buscador de Máximas
Se solicitó desarrollar para una empresa un código que le permita a su buscador ver cuales son las palabras/frase con mayor número de iteraciones en un archivo `.csv`. Para eso se implementaron dos métodos de búsqueda y organización de datos: Heap y uno a elección(QuickSort). Además se pide que se hacer 3 tipos de consulta adicionales: Cuánto tiempo tarda cada método, la devolución de la rama izquierda de la Heap y una devolución de cada elemento por nivel de la Heap.
## 📚 Índice
- [🧭 Búsqueda](#-búsqueda)
- [❔ Consultas](#-consultas)
- [🧰 Tecnologías Implementadas](#-tecnologías-implementadas)
- [👥 Participantes](#-participantes)
- [🙏 Agradecimientos](#-agradecimientos)

---

## 🧭 Búsqueda
En primer lugar iniciamos nuestro buscador de iteraciones, en él, observamos que tiene 2 opciones, la primera con el heap y la segunda con el otro método (`QuickSort`). Además observamos que hay un barra que sirve para marcar cuántas devoluciones queremos(Ej: "Resultados: 2": 1ra frase con más iteraciones, 2da frase con más iteraciones).
![buscador](img/buscador.png)
- ### 1 Devolución
![1-busqueda](img/busq1.png)
- ### 2 Devoluciones
![2-busqueda](img/busq2.png)
- ### 3 Devoluciones
![3-busqueda](img/busq3.png)
- ### 4 Devoluciones
![4-busqueda](img/busq4.png)
- ### 5 Devoluciones
![5-busqueda](img/busq5.png)

---
## ❔ Consultas
- ### Consulta 1
En la primera consulta se muestra cuánto tiempo tarda en en buscar, organizar y devolver los datos, tanto con el método Heap, como con el QuickSort.
![consulta-1](img/con1.png)
- ### Consulta 2
En la segunda consulta se muestran todas las devoluciones con mayor iteración por cada nivel.
![consulta-2](img/con2.png)
- ### Consulta 3
En la tercera consulta se muestran todas las devoluciones por nivel y el número de iteraciones.
![consulta-3](img/con3.png)

---

## 🧰 Tecnologías Implementadas
| Tecnología/Herramienta | Característica |
|--|--|
| **C#** | Lenguaje de programación |
| **SharpDevelop** | Entorno de Desarrollo |
| **Visual Studio Code** | Entorno de Desarrollo |
| **Live Share** | Extensión de Visual Studio Code |

---

## 👥 Participantes
**Brandan Alejo:** [github.com/AleGarg](https://github.com/AleGarg) <br>
**Insaurralde Fabrizio:** [github.com/Perasilvestre](https://github.com/Perasilvestre) <br>
**Vera Mateo:** [github.com/MATT367](https://github.com/MATT367)

---

## 🙏 Agradecimientos
**UNAJ:** Universidad Nacional Arturo Jauretche. <br>
**Leandro Caballero:** Docente en la UNAJ y UTN.
