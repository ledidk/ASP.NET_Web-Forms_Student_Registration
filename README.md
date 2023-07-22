# ASP.NET_Web-Forms_Student_Registration

**Student Registration System**

This college project (Lab 8)  is a student registration system developed using ASP.NET Web Forms. The application enables students to register for courses based on their enrollment status (Full Time, Part Time, or Co-op). It also restricts the number of courses and weekly hours based on the student's enrollment type.

**Table of Contents**

1. Models
2. Helper
3. AddStudent.aspx
4. RegisterCourse.aspx
5. Global.asax


**1 Models:**

The project includes the following model classes representing different types of students and courses:

- Student.cs:
- CoopStudent.cs:
- ParttimeStudent.cs
- FulltimeStudent.cs
- Helper.cs:
- Course.cs


**2. Helper:**

The Helper class in the Models folder provides utility methods to retrieve available courses and find a course by its code.
AddStudent.aspx

**3. The AddStudent.aspx:**

page allows users to add new students to the system. They can specify the student's name and enrollment type (Full Time, Part Time, or Co-op). After adding a student, they can proceed to register for courses.

**4. RegisterCourse.aspx:**

The RegisterCourse.aspx page enables students to register for courses based on their enrollment status. Available courses are displayed in a checkbox list, and students can select the courses they want to register for. The system ensures that the selected courses comply with the maximum weekly hours and number of courses allowed for each enrollment type.

**5. Global.asax:**

The Global.asaz file contains the application's global settings and configurations. In this project, it sets the maximum weekly hours and the maximum number of courses allowed for each enrollment type (Full Time, Part Time, and Co-op).

** How to Use **

Clone the repository to your local machine.
Open the solution in Visual Studio.
Build and run the application.
Access the application in your web browser.
Feel free to customize the project according to your preferences and add more features if needed.

