# TodoList

## Realizar Fork

- Construir una lista de tareas (TodoList) utilizando Programación Orientada a Objetos (POO) en C#:

- Crear una clase Task que represente una tarea individual, con atributos como el nombre de la tarea, la descripción, la fecha de vencimiento, y el estado (completada o no completada).

- Crear una clase TodoList que represente la lista de tareas. Esta clase tendría una lista de objetos de la clase Task y tendría métodos para agregar, eliminar y marcar tareas como completadas.

- Crear una interfaz gráfica de usuario (GUI) mediante consola, utilizando el patrón MVC (Modelo-Vista-Controlador) para que los usuarios puedan interactuar con la lista de tareas.

- Los alumnos podrían agregar métodos adicionales para mejorar la funcionalidad de la TodoList, como la capacidad de ordenar las tareas por fecha de vencimiento o por nombre, o la capacidad de buscar tareas específicas.


## Aspectos importantes:
### La clase Task representa una tarea individual y se considera un objeto. Esta clase tiene atributos como el nombre de la tarea, la descripción, la fecha de vencimiento, y el estado (completada o no completada), que son considerados como variables de instancia. También tiene métodos como MarkAsCompleted() y Edit() que son acciones que puede realizar una tarea.

### La clase TodoList representa la lista de tareas y también se considera un objeto. Esta clase tiene una lista de objetos de la clase Task y tiene métodos como AddTask(), RemoveTask() y MarkTaskAsCompleted(), que permiten al usuario interactuar con las tareas individuales.

### La interfaz gráfica de usuario (GUI) se considera como un controlador, ya que se encarga de recibir la entrada del usuario y comunicarla al modelo (la clase TodoList) para que se realice la acción correspondiente.

### El patrón MVC se utiliza para separar las responsabilidades en tres partes distintas: el modelo (la lógica de negocio), la vista (la interfaz gráfica de usuario) y el controlador (que se encarga de la comunicación entre el modelo y la vista).

## Realizar Entrega a traves de un Pull Requests
