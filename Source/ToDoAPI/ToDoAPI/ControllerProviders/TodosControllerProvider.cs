﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Remotion.Linq.Utilities;
using ToDoAPI.ControllerProviders.Interfaces;
using ToDoAPI.DAL;
using ToDoAPI.DAL.Interfaces;
using ToDoAPI.DomainModels;

namespace ToDoAPI.ControllerProviders
{
    public class TodosControllerProvider : ITodosControllerProvider
    {
        private readonly ITodosRepository _todoRepository;

        public TodosControllerProvider(ITodosRepository todoRepository)
        {
            try
            {
            _todoRepository = todoRepository;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IQueryable<Todo> GetAllTodos()
        {
            try
            {
                return _todoRepository.GetAll();
            }
            catch (Exception e)
            {
                throw e;
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
                throw e;
            }
        }

        public async Task<Todo> AddTodo(Todo newTodo)
        {
            if (newTodo != null)
            {
                try
                {
                    if (await _todoRepository.Add(newTodo) > 0)
                    {
                        return newTodo;
                    };
                    throw new NullReferenceException(); ;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
                throw new NullReferenceException();
        }

        public async Task DeleteTodo(int id)
        {
            try
            {
                await _todoRepository.Delete(id);
            }
            catch (Exception e)
            {
                throw e;
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
                throw e;
            }
        }

    }
}
