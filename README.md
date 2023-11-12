# TRABAJO PRACTICO N°1 - PARTE2 - CALABACINES 🎃
## 🕹 Infinite Jumping "Calabacines" 
Imaginen un juego llamado "Calabacines" donde el player va saltando sobre plataformas de nubes evitando caer sobre un suelo de calabazas de monster. Ademas el player debe juntar diamantes sin tocar a los enemigos ya que le quitar 1 diamante. el objetivo es recolectar el mayor numero de diamantes, si el numero de diamantes es cero, termina el juego.

## MECANICAS 
### JUGADOR 🧍‍♂️
- El personaje puede saltar presionando la tecla espacio.
### Plataformas (Nubes) ☁
- Las nubes son las platafomas en las que puede saltar (tiene collider).
- Deben generarse cada cierto tiempo aleatorio en la parte superior de la pantalla y moverse hacia abajo.
- Deben desaparecer cuando tocan el fondo.

### Diamantes 💎
- Los diamantes son objetos que Calabacino debe recolectar para ganar puntos (+1).
- Deben generarse en tiempo aleatorio en la parte superior de la pantalla y moverse hacia abajo. Deben desaparecer de forma aleatoria cuando tocan el fondo.

### Monstruos 👾
- Los monstruos son enemigos que Calabacino debe evitar. Si Calabacino toca un monstruo se le descuenta un diamante (-1).
- Deben generarse en tiempos aliatoriamente en la parte superior de la pantalla y moverse hacia abajo.

### Recomendaciones ☝🤓
- Utilizar Prefabs para crear nubes, diamantes y monstruos.
- Implementar las mecanicas del juego utilizando corrutinas para generar nubes, diamantes y monstruos de manera aleatoria cuando tocan el fondo detectando la colision.
- Usa GetComponent para acceder al contador de puntuacion.
- Agrega música de fondo y efectos sonoros para mejorar la experiencia del juego.
- Opcional: Utiliza Invoke para aumentar gradualmente la velocidad y dificultad del juego con el tiempo.
- En todo los casos comentar los scripts y fundamentar las desiciones en caso de falta de informacion o ambiguiedades.

## 📦 Version Unity 2022.3.9f1
- Estudiante: Vilca Carlos Norberto Salvador
- LU: 646
- Asignatura: Programacion de VideoJuegos 1
- Docentes: Vega Ariel Alejandro - Bustamante Samuel