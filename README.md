## NQueen
This project is using C# and created by Microsoft Visual Studio (2019) to solve n queen problem.
 
## Administration Menu
.
├── NQueen
│   ├── NQueen.cs
│   ├── NQueen.csproj
│   ├── Tester.cs
│   └── Program.cs
├── bin/Release/netcoreapp3.1
│   ├── NQueen.deps.json
│   ├── NQueen.dll
│   ├── NQueen.exe
│   ├── NQueen.pdb
│   ├── NQueen.runtimeconfig.dev.json
│   └── NQueen.runtimeconfig.json
├── NQueen.sln
└── README.md

2 directories, 12 files


## Requirements
In chess, a queen can attack horizontally, vertically, and diagonally. The N-queens problem asks:
- The agorithm should provid all posible solution that N queens be placed on an NxN chessboard so that no two of them attack each other.
- Run 20x20 board in acceptable time.
- minimize memory usage.


## Build
- Open NQueen.sln with Microsoft Visual Studio (2019)
- Click Build / Build Solution
- The build NQueen.exe will be generated under bin/Release/ folder

# Test1 - test the sum of posible solution
As we known the total number of solution of n queen as the table below,
the module can present the number solution to test.

| N  | Total Solutions   | Unique Solutions |   Tot. Sol.   |   Unique Sol.  |
| -- | ----------------- | ---------------- | ------------- | -------------  |
|  1 |                1  |               1  |             1 |             1  |
|  2 |                0  |               0  |             0 |             0  |
|  3 |                0  |               0  |             0 |             0  |
|  4 |                2  |               1  |             0 |             0  |
|  5 |               10  |               2  |             0 |             0  |
|  6 |                4  |               1  |             0 |             0  |
|  7 |               40  |               6  |             0 |             0  |
|  8 |               92  |              12  |             0 |             0  |
|  9 |              352  |              46  |             0 |             0  |
| 10 |              724  |              92  |             4 |             1  |
| 11 |             2680  |             341  |            44 |             6  |
| 12 |            14200  |            1787  |           156 |            22  |
| 13 |            73712  |            9233  |          1876 |           239  |
| 14 |           365596  |           45752  |          5180 |           653  |
| 15 |           2279184 |           285053 |         32516 |          4089  | 
| 16 |          14772512 |          1846955 |        202900 |         25411  | 
| 17 |          95815104 |         11977939 |       1330622 |        166463  | 
| 18 |         666090624 |         83263591 |       8924976 |       1115871  | 
| 19 |        4968057848 |        621012754 |      64492432 |       8062150  | 
| 20 |       39029188884 |       4878666808 |     495864256 |      61984976  | 
| 21 |      314666222712 |      39333324973 |    3977841852 |     497236090  | 
| 22 |     2691008701644 |     336376244042 |   34092182276 |    4261538564  | 
| 23 |    24233937684440 |    3029242658210 |  306819842212 |   38352532487  | 
| 24 |   227514171973736 |   28439272956934 | 2883202816808 |  360400504834  | 
| 25 |  2207893435808352 |  275986683743434 |28144109776812 | 3518014210402  | 


Test steps:
- Select Test mode
- Input number to test
- Check if the sum of solutions are identical.

# Test2 - test the result of small number of queen

Solution of 4 Queens as below,

Solution #1:

_    Q    _    _    
_    _    _    Q    
Q    _    _    _    
_    _    Q    _    


Solution #2:

_    _    Q    _    
Q    _    _    _    
_    _    _    Q    
_    Q    _    _   

Test steps:
- Select Solution mode
- Input 4 to test
- Check if the solutions are correct as above.

## Run
- Click NQueen.exe in the folder bin/Release/netcoreapp3.1
