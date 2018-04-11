import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Todo } from '../../todo';

@Component({
  selector: 'todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent {
@Input()
todos:Todo[];

@Output()
remove:EventEmitter<Todo> = new EventEmitter();

@Output()
toggleComplete:EventEmitter<Todo> = new EventEmitter();
  
editState:boolean = false;

@Output()
todoToEdit:Todo = new Todo();

@Output()
update:EventEmitter<Todo> = new EventEmitter();

constructor() { }

onEditTodo(event, todo){
  this.editState=true;
  this.todoToEdit = todo;
}

onToggleTodoComplete(todo: Todo) {
  this.toggleComplete.emit(todo);
}

onRemoveTodo(todo: Todo) {
  this.remove.emit(todo);
}

  onEdit(todo: Todo) {
    if (this.todoToEdit == null){
      this.todoToEdit = todo;
    }
    if (this.todoToEdit !== todo) {
      this.todoToEdit = todo;
 
    }

    this.editState = !this.editState;

  }

  onUpdate(todo:Todo){
    this.update.emit(todo);
    this.editState = !this.editState;
  }

}
