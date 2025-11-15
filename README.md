# 🌳 Innovatec — Árboles y Grafos en C#

## 📘 Descripción
Este proyecto es un caso de estudio para el **Parque Tecnológico Innovatec**, desarrollado en **C# con Windows Forms**.  
El sistema permite:
- Administrar la **jerarquía organizativa** del parque mediante un **árbol general**.
- Modelar las **rutas internas entre edificios** utilizando un **grafo no dirigido y ponderado**.

---

## 🎯 Objetivos
- **Parte A: Árbol — Jerarquía Organizativa**
  - Registrar la jerarquía como un árbol general.
  - Implementar funcionalidades de **insertar, buscar, recorrer, contar y niveles**.
  - Mostrar visualmente la jerarquía en un `TreeView`.

- **Parte B: Grafo — Sistema de Rutas**
  - Representar edificios y conexiones mediante una **lista de adyacencia**.
  - Implementar funciones para **mostrar conexiones, validar conexidad (BFS) y calcular rutas más cortas (Dijkstra)**.
  - Mostrar resultados en `ListBox` y mensajes de estado en `Label`.

---

## 🛠️ Tecnologías utilizadas
- Lenguaje: **C#**
- Entorno: **Visual Studio / WinForms**
- Estructura:  
  - `Models/` → Clases de lógica (`Nodo`, `Arbol`, `Grafo`).  
  - Formularios → `FrmPrincipal`, `FrmArbolJerarquia`, `FrmGrafoRutas`.

---

## 📂 Funcionalidades implementadas

### 🌳 Árbol
- **Insertar nodos**: agregar hijos a un padre existente.
- **Buscar nodos**: resalta el nodo en el `TreeView`.
- **Recorrer árbol**: muestra recorrido con niveles en un `ListBox`.
- **Contar nodos**: devuelve el total de nodos.
- **Nivel de nodo**: indica en qué nivel se encuentra un nodo.

### 🏢 Grafo
- **Agregar conexiones**: origen ↔ destino con peso.
- **Mostrar conexiones**: lista todas las aristas.
- **Validar conexidad (BFS)**: comprueba si todos los nodos están conectados.
- **Ruta más corta (Dijkstra)**: calcula distancia mínima y reconstruye el camino.

---

## 📊 Ejemplo de uso

### Árbol
1. Insertar: Padre = `Parque Innovatec`, Hijo = `Edificio A`.
2. Insertar: Padre = `Edificio A`, Hijo = `Departamento 1`.
3. Buscar: `Departamento 1` → resaltado en el `TreeView`.

### Grafo
1. Agregar conexión: Origen = `Edificio A`, Destino = `Edificio B`, Peso = `5`.
2. Validar conexidad → “El grafo es conexo”.
3. Ruta más corta: Inicio = `Edificio A`, Destino = `Edificio C` → muestra distancia y camino.

---

## 📘 Explicación técnica

- **Lista de adyacencia**: cada nodo guarda una lista de sus vecinos y pesos → eficiente en grafos dispersos.
- **BFS (Breadth-First Search)**: recorre el grafo por niveles → usado para validar conexidad.
- **Dijkstra**: calcula la ruta más corta en grafos ponderados → usado para encontrar caminos mínimos entre edificios.

---

## 🧑‍💻 Autor
- **Joshua** — Universidad Americana (UAM)  
- Proyecto académico: **Programacion estructurada
