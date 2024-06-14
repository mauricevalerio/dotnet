import { TodoItem, AddTodoItem } from '../types';

const URI = "https://localhost:7288/api/";

export async function getTodoItems() {
    const response = await fetch(`${URI}TodoItems`);
    const data = await response.json();
    return data;
}

export async function postTodoItem(todoItem: AddTodoItem) {
    const resp = await fetch(`${URI}TodoItems`, {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
        },
        body: JSON.stringify(todoItem)
    });
    const data = resp.json();
    return data;
}

export async function deleteTodoItem(id: number) {
    await fetch(`${URI}TodoItems/${id}`, {
        method: "DELETE",
        headers: {
            "Content-Type": "application/json",
        }
    });
}

export async function patchTodoItem(id: number) {
    await fetch(`${URI}TodoItems/${id}`, {
        method: "PATCH",
        headers: {
            "Content-Type": "application/json",
        }
    });
}

export async function putTodoItem(id: number, todoItem: TodoItem) {
    await fetch(`${URI}TodoItems/${id}`, {
        method: "PUT",
        headers: {
            "Content-Type": "application/json",
        },
        body: JSON.stringify(todoItem)
    });
}