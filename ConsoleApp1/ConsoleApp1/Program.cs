int i = 16;
int n = 10;
int[] v = new int[n];


// short circuit evaluation
if (i < n && v[i] < 42)
    v[i]++;


if (v[i] < 42 && i < n)
    v[i]++;


