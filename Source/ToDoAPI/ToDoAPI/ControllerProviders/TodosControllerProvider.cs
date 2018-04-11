﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Remotion.Linq.Utilities;
using ToDoAPI.ControllerProviders.Interfaces;
using ToDoAPI.DAL;
using ToDoAPI.DomainModels;

namespace ToDoAPI.ControllerProviders
{
    public class TodosControllerProvider : ITodosControllerProvider
    {
        private readonly TodosRepository _todoRepository;

        public TodosControllerProvider(TodosRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public IQueryable<Todo> GetAllTodos()
        {
            try
            {
                return _todoRepository.GetAll();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<Todo> GetTodoById(int id)
        {
            try
            {
                return await _todoRepository.GetById(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task AddTodo(Todo newTodo)
        {
            try
            {
                await _todoRepository.Add(newTodo);
            }
            catch (Exception e)
            {

            }
        }

        public async Task DeleteTodo(int id)
        {
            try
            {
                await _todoRepository.Delete(id);
            }
            catch (Exception e)
            {
            }
        }

        public async Task UpdateTodo(Todo todo)
        {
            try
            {
                await _todoRepository.Update(todo);
            }
            catch (Exception e)
            {

            }
        }

    }
}