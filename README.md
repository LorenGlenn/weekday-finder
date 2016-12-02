# ReadMe

| Test                                                   | Input       | Output       |
|--------------------------------------------------------|-------------|--------------|
| Count difference in days from Epoch date               | "1/10/2000" | 9            |
| Count difference in days over a month                  | "2/5/2000"  | 35           |
| Count difference in days over a year                   | "1/1/2001"  | 365          |
| Output correct day of the week in regards to day count | "1/5/2000"  | Wednesday    |
| Enter an invalid date                                  | "2/29/2015" | Invalid Date |
| Enter a future date                                    | "12/1/2017" | Friday       |



string[] weekdays[Sat, Sun, Mon, Tues, Weds, Thurs, Fri]


[InlineData("12/31/2000", "Sunday")]
[InlineData("1/1/2001", "Monday")]
[InlineData("1/1/2003", "Wednesday")]
[InlineData("1/1/2004", "Thursday")]
[InlineData("3/1/2002", "Friday")]
[InlineData("9/5/2005", "Monday")]


TODO: Set definitions for MONTH = splitInputDate[0], etc
