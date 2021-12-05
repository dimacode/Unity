// Дебагинг
// using UnityEngine;
UnityEngine.Debug.Log("Cursor position" + Input.mousePosition.x);
//-------------------------------------------------------------------------------------------------------------------------------------

// Input (Доступ ко многим вещам таких как Мышка.Клава)
// Мышка
Input.mousePosition.x
Input.mousePosition.y

Input.GetMouseButton(0)
// Debug.Log("Pressed left click.");
Input.GetMouseButton(1)
// Debug.Log("Pressed right click.");
Input.GetMouseButton(2)
// Debug.Log("Pressed middle click.");
Input.GetMouseButtonUp(0)
// Debug.Log("Pressed left click.");
Input.GetMouseButtonUp(1)
// Debug.Log("Pressed right click.");
Input.GetMouseButtonUp(2)
// Debug.Log("Pressed middle click.");


// Клава (KeyCode)
Input.GetKey("up"))
// print("up arrow key is held down");
Input.GetKey("down")
// print("down arrow key is held down");
Input.GetKeyDown(KeyCode.Space)
// Debug.Log("Space key was pressed.");
Input.GetKeyDown("space")
// print("space key was pressed");