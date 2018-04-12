import { Component, OnInit } from '@angular/core';
import { TodoDataService } from './services/todo-data.service';
import { Todo } from './todo';
// import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  todos: Todo[] = [];

  constructor(private todoService: TodoDataService) {
  }

  ngOnInit(): void {
    this.todoService
      .getAllTodo()
      .subscribe(todos => { this.todos = todos });
  }

  onAddTodo(todo) {
    this.todoService
      .addTodo(todo)
      .subscribe(newTodo => { this.todos.push(newTodo) });
  }

  onRemoveTodo(todoToDelete) {
    this.todoService
      .deleteTodoById(todoToDelete.id)
      .subscribe(deleted=>{
       this.todos = this.todos.filter(todo=>todo.id !== todoToDelete.id) 
      });
  }

  onToggleTodoComplete(todo: Todo) {
    this.todoService
      .toggleTodoComplete(todo)
      .subscribe(updatedTodo => {
        todo = updatedTodo;
      });
  }

  onUpdate(todo:Todo){
    this.todoService
      .updateTodoById(todo)
      .subscribe(updatedTodo => {
        todo = updatedTodo;
      });
  }


}
