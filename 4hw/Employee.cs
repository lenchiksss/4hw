class Employee
{
    private string name;
    private double salary;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public static Employee operator +(Employee employee, double increaseAmount)
    {
        employee.Salary += increaseAmount;
        return employee;
    }

    public static Employee operator -(Employee employee, double decreaseAmount)
    {
        employee.Salary -= decreaseAmount;
        return employee;
    }

    public static bool operator ==(Employee employee1, Employee employee2)
    {
        return employee1.Salary == employee2.Salary;
    }

    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return employee1.Salary != employee2.Salary;
    }

    public static bool operator <(Employee employee1, Employee employee2)
    {
        return employee1.Salary < employee2.Salary;
    }

    public static bool operator >(Employee employee1, Employee employee2)
    {
        return employee1.Salary > employee2.Salary;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Employee))
        {
            return false;
        }

        Employee employee = (Employee)obj;
        return this.Salary == employee.Salary;
    }
}