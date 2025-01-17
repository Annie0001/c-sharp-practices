﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// ************** Project overview *************
// You're developing a Student Grading application that automates 
// the calculation of current grades for each student in a class. The parameters for your application are:
// You're given a short list of four students and their five assignment grades.
// Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.
// Final scores are calculated as an average of the five assignment scores.
// Your application needs to perform basic math operations to calculate the final grades for each student.
// Your application needs to output/display each student’s name and final score.

// Sophia: 93, 87, 98, 95, 100

// Nicolas: 80, 83, 82, 88, 85

// Zahirah:   84, 96, 73, 85, 79

// Jeong:  90, 92, 98, 100, 97

// Student     Grade
// Sophia      94.6  A
// Nicolas     83.6  B
// Zahirah     83.4  B
// Jeong       95.4  A

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

decimal sophiaScore = sophiaSum / currentAssignments;
decimal nicolasScore = nicolasSum / currentAssignments;
decimal zahirahScore = zahirahSum / currentAssignments;
decimal jeongScore = jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");

Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");
