/*
Name: Marc Domingo
Student ID: 2346778
Chapman Email: mdomingo@chapman.edu
Course Number and Section: 236-03
Assignment: Project 2
This is my own work, and I did not cheat on this assignment.
*/

// The purpose of this project is to display a random student's name from a file on the screen when a button on Unity's UI is pressed.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    // Load the file of student names
    // On button click in UI, randomly pick a student name
    // Assign to text object in GUI the chosen student name

    // Can be changed later via Unity
    public string fileName = "default.txt";
    // The display textbox object in Unity
    public Text displayName;
    // The array that will be used to store the names of students from a file
    private string[] studentNames;

    // Start is called before the first frame update
    void Start()
    {
        LoadStudentNames();
    }

    // Function to be used to fill the array "studentNames" with the names of students from a file. 
    private void LoadStudentNames()
    {
        // For each line in the opened file, add the name to the array of student names.
        this.studentNames = File.ReadAllLines(fileName);
    }

    // Function that is called whenever the UI button in Unity is pressed.
    public void ButtonClick()
    {
        // Generate a random number between 0 (inclusive) and the length of the array "studentNames" (exclusive).
        int i = UnityEngine.Random.Range(0, this.studentNames.Length);
        // Using the randomly generated number, assign the string variable "name" to the student's name at a specific index within the array "studentNames."
        string name = this.studentNames[i];
        // Display the chosen name onto the textbox in Unity.
        displayName.text = name;
    }
}
