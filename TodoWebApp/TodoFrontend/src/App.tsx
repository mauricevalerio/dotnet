import { useEffect, useState } from 'react'
import { getTodoItems, postTodoItem, deleteTodoItem, patchTodoItem } from "../api"
import { TodoItem, AddTodoItem } from "../types"


export default function App() {
  const [todoItemsData, setTodoItemsData] = useState<TodoItem[]>([]);
  const [newTodo, setNewTodo] = useState<AddTodoItem>({
    name: "",
    isComplete: false
  });

  async function onComplete(id: number) {
    setTodoItemsData(prevData => prevData.map(item => {
      return item.id === id ? { ...item, isComplete: !item.isComplete } : item
    }))

    await patchTodoItem(id);
  }

  function onFormChange(e: React.ChangeEvent<HTMLInputElement>) {
    setNewTodo(prevData => ({ ...prevData, name: e.target.value }))
  }

  async function onPost(e: React.FormEvent) {
    e.preventDefault();

    if (newTodo.name !== "") {
      const postData = await postTodoItem(newTodo);
      setTodoItemsData(prevData => ([...prevData, postData]));
    }

    setNewTodo(prevData => ({ ...prevData, name: "" }))
  }

  async function onDelete(id: number) {
    setTodoItemsData(prevData => prevData.filter(item => item.id !== id));
    await deleteTodoItem(id);
  }

  useEffect(() => {
    async function getData() {
      const data = await getTodoItems();
      setTodoItemsData(data);
    }
    getData();
  }, [])

  return (
    <section>
      <h1>To do list</h1>
      <h2>React + ASP.NET Core Web API</h2>
      <form onSubmit={onPost}>
        <input type="text" name="name" value={newTodo?.name} onChange={onFormChange} />
        <button>Submit</button>
      </form>
      {todoItemsData.length !== 0 ?
        <ul>
          {todoItemsData.map(item => <li key={item.id}>
            <div className='btn-group'>
              <input type="checkbox" id={item.name} checked={item.isComplete} onChange={() => onComplete(item.id)} />
              <label htmlFor={item.name} className={item.isComplete ? "strikethrough" : undefined}>{item.name}</label>
              <button onClick={() => onDelete(item.id)}>Delete</button>
            </div>
          </li>
          )}
        </ul>
        :
        <p>No to do items yet</p>
      }

    </section>
  )
}