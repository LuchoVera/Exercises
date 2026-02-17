# 🚀 C# LINQ Training — Practical Exercise Set

---

# 📘 SECTION 1 — Basic Filtering & Selection

---

## 🟢 Exercise 1 — Even Numbers (Three Query Parts)

### Objective:
Demonstrate the three parts of a LINQ query:
1. Data source  
2. Query creation  
3. Query execution  

### Task:
Display numbers that produce remainder 0 after dividing by 2.

### Expected Output:
The numbers which produce the remainder 0 after divided by 2 are :
0 2 4 6 8

---

## 🟢 Exercise 2 — Range Filtering with Two Conditions

### Task:
Find positive numbers within the range 1 to 11 using TWO `where` conditions.

### Expected Output:
The numbers within the range of 1 to 11 are :
1 3 6 9 10

---

## 🟢 Exercise 3 — Number and Square (Projection)

### Task:
Display each number and its square.

### Expected Output:
{ Number = 9, SqrNo = 81 }
{ Number = 8, SqrNo = 64 }
{ Number = 6, SqrNo = 36 }
{ Number = 5, SqrNo = 25 }

---

## 🟢 Exercise 4 — Numbers Greater Than 80

### Task:
Create a list and display numbers greater than 80.

### Expected Output:
200
740
230
482
95

---

# 📘 SECTION 2 — Grouping & Frequency

---

## 🟡 Exercise 5 — Number Frequency

### Task:
Display number and its frequency in an array.

### Expected Output:
Number 5 appears 3 times
Number 9 appears 2 times
Number 1 appears 1 times

---

## 🟡 Exercise 6 — Character Frequency in String

### Input:
apple

### Task:
Display character frequency.

### Expected Output:
Character a: 1 times
Character p: 2 times
Character l: 1 times
Character e: 1 times

---

## 🟡 Exercise 7 — Multiplication with Frequency

### Task:
Display:
- Number
- Number × Frequency
- Frequency

### Expected Output:
Number  Number*Frequency  Frequency
5       15                3
1       1                 1
9       9                 1
2       4                 2

---

## 🟡 Exercise 8 — File Extension Grouping

### Task:
Count file extensions and group them using LINQ.

### Expected Output:
1 File(s) with .frx Extension
3 File(s) with .txt Extension
1 File(s) with .dbf Extension
2 File(s) with .pdf Extension
1 File(s) with .frt Extension
1 File(s) with .xml Extension

---

# 📘 SECTION 3 — String Operations

---

## 🔵 Exercise 9 — Starts and Ends With

### Task:
Find city names that:
- Start with specific character
- End with specific character

### Example:
Start: A  
End: M  

### Expected Output:
AMSTERDAM

---

## 🔵 Exercise 10 — Uppercase Words

### Input:
this IS a STRING

### Task:
Find all uppercase words.

### Expected Output:
IS
STRING

---

## 🔵 Exercise 11 — Convert String Array to Single String

### Task:
Convert string array into a single comma-separated string.

### Expected Output:
cat, dog, rat

---

# 📘 SECTION 4 — Ordering & Top Records

---

## 🔴 Exercise 12 — Top N Records

### Task:
Display top N highest numbers.

### Example:
Top 3 →

24  
13  
9  

---

## 🔴 Exercise 13 — Nth Maximum Grade Point

### Task:
Find the Nth maximum grade point among students.

Example:
Find 3rd maximum grade.

### Expected Output:
Id : 7, Name : David, achieved Grade Point : 750  
Id : 10, Name : Jenny, achieved Grade Point : 750  

---

# 📘 SECTION 5 — User Input Scenarios

---

## 🟣 Exercise 14 — Filter from User Input

### Task:
- Accept list members from keyboard
- Ask for threshold value
- Display numbers greater than threshold

### Expected Output:
94  
63  

---

## 🟣 Exercise 15 — Display Days of the Week

### Task:
Display names of days using LINQ.

Expected Output:
Sunday  
Monday  
Tuesday  
Wednesday  
Thursday  
Friday  
Saturday  

---

# 🧠 BONUS CHALLENGES (Advanced Thinking)

---

## 🔥 Bonus 1 — Case-Insensitive File Extension Grouping

Make extension grouping fully case-insensitive.

---

## 🔥 Bonus 2 — Optimize Nth Maximum Query

Avoid sorting full list.  
Try using:

- Distinct()
- OrderByDescending()
- Skip()

---

## 🔥 Bonus 3 — Deferred Execution Investigation

Answer:

1. When does LINQ execute?
2. What is deferred execution?
3. What happens if you modify the source collection after creating the query?

---

# 🏆 LINQ Concepts Covered

✔ Filtering (Where)  
✔ Projection (Select)  
✔ Ordering (OrderBy / ThenBy)  
✔ Grouping (GroupBy)  
✔ Aggregation (Count, Sum, Max)  
✔ String operations  
✔ Top records (Take / Skip)  
✔ Anonymous types  
✔ Case-insensitive comparisons  
✔ Query syntax vs Method syntax  

---
