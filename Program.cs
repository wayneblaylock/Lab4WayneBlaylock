string[] firsts_bank = {"James", "John", "Robert", "Michael", "William", "David", "Richard", "Charles", "Joseph", "Thomas", "Mary", "Patricia", "Jennifer", "Linda", "Elizabeth", "Barbara", "Susan", "Jessica", "Sarah", "Karen"};
string[] middles_bank = {"Mae", "Marie", "Elizabeth", "May", "Louise", "Mary", "Margaret", "Irene", "Ann", "Lee", "William", "Joseph", "Edward", "John", "Henry", "James", "Francis", "Charles", "Lee", "George"};
string[] lasts_bank = {"Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Garcia", "Rodriguez", "Wilson", "Martinez", "Anderson", "Taylor", "Thomas", "Hernandez", "Moore", "Martin", "Jackson", "Thompson", "White"};
string[] jobs_bank = {"Truck Driver", "Nurse", "Retail Worker", "Software Developer", "Customer Service", "Marketing", "Web Developer", "Engineer", "Doctor", "Physical Therapist", "Dentist", "Electrical Engineer", "Pilot", "Teacher", "Acocuntant"};
decimal[] wages_bank = {7.25m, 8.00m, 8.50m, 9.00m, 9.50m, 10.00m, 10.50m, 11.00m, 11.50m, 12.00m, 12.50m, 13.00m, 15.00m, 17.50m, 18.00m, 20.00m, 25.00m, 30.00m, 35.00m, 40.00m, 50.00m};

string[] names = new string[1000];
string[] jobs = new string[1000];
decimal[] wages = new decimal[1000];
decimal[] salaries = new decimal[1000];

Random rnd = new Random();


List<string> used_names = new List<string>();


for(int i = 0; i<1000; i++) {
Console.Write($"{i+1}  ");

//Generates a new unique name, and set it in the names array
while(true){
int first_index  = rnd.Next(0, firsts_bank.Length);
int middle_index  = rnd.Next(0, middles_bank.Length);
int last_index  = rnd.Next(0, lasts_bank.Length);
string full_name = $"{firsts_bank[first_index]} {middles_bank[middle_index]} {lasts_bank[last_index]}";
foreach (string x in used_names){
    if (x == full_name){continue;}}
used_names.Add(full_name);
Console.Write($"Name: {full_name}   ");
names[i] = full_name;
break;
}

int job_index  = rnd.Next(0, jobs_bank.Length);
string job = jobs_bank[job_index];
Console.Write($"Occupation: {job}   ");
jobs[i] = job;

int wage_index  = rnd.Next(0, wages_bank.Length);
decimal wage = wages_bank[wage_index];
Console.Write($"Hourly Wage: {wage}   ");
wages[i] = wage;

decimal salary = wage * 40 * 50;
Console.WriteLine($"Anual Salary: {salary}");
salaries[i] = salary;


}