class Matrix
{
    private int rows;
    private int cols;
    private int[,] data;

    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        data = new int[rows, cols];
    }

    public int Rows
    {
        get { return rows; }
    }

    public int Cols
    {
        get { return cols; }
    }

    public int this[int row, int col]
    {
        get { return data[row, col]; }
        set { data[row, col] = value; }
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
        {
            throw new ArgumentException("Матриці мають різний розмір.");
        }

        Matrix result = new Matrix(a.Rows, a.Cols);

        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Cols; j++)
            {
                result[i, j] = a[i, j] + b[i, j];
            }
        }

        return result;
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
        {
            throw new ArgumentException("Матриці мають різний розмір.");
        }

        Matrix result = new Matrix(a.Rows, a.Cols);

        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Cols; j++)
            {
                result[i, j] = a[i, j] - b[i, j];
            }
        }

        return result;
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.Cols != b.Rows)
        {
            throw new ArgumentException("Неправильний розмір матриць.");
        }

        Matrix result = new Matrix(a.Rows, b.Cols);

        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < b.Cols; j++)
            {
                int sum = 0;
                for (int k = 0; k < a.Cols; k++)
                {
                    sum += a[i, k] * b[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }

    public static Matrix operator *(Matrix matrix, int number)
    {
        Matrix result = new Matrix(matrix.Rows, matrix.Cols);

        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Cols; j++)
            {
                result[i, j] = matrix[i, j] * number;
            }
        }

        return result;
    }

    public static bool operator ==(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
        {
            return false;
        }

        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Cols; j++)
            {
                if (a[i, j] != b[i, j])
                    return false;
            }
        }

        return true;
    }

    public static bool operator !=(Matrix a, Matrix b)
    {
        return !(a == b);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Matrix))
        {
            return false;
        }

        return this == (Matrix)obj;
    }
}