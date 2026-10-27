# LeetCode C# Workspace

A local environment for solving LeetCode problems in C#. It lets you write a solution, test it against multiple cases, and inspect the output without pasting code into the LeetCode editor each time.

## Features

- **Solutions library**: one file and one namespace per problem, so every problem can keep LeetCode's required `Solution` class name.
- **xUnit tests**: run many test cases per problem, including validator-style tests for problems that accept any valid answer.
- **Console playground**: run a solution quickly and print the result.
- **Debugging**: set breakpoints in a solution and debug straight from a test.

## Project structure

```
LeetCode.sln
├── LeetCode.Solutions/     # Solutions, one file per problem
│   └── CreateGridWithExactlyOnePath.cs
├── LeetCode.Tests/         # xUnit tests, one test file per problem
│   └── CreateGridWithExactlyOnePathTests.cs
└── LeetCode.Playground/    # Console app for quick experiments
    └── Program.cs
```

## Requirements

- Visual Studio 2022 with the **.NET desktop development** workload
- .NET 8.0 SDK

## Getting started

```bash
git clone https://github.com/<your-username>/<repo-name>.git
cd <repo-name>
```

Open `LeetCode.sln` in Visual Studio, then build with **Ctrl+Shift+B**.

## Running tests

1. Open **Test → Test Explorer**.
2. Press **Ctrl+R, A** to run all tests.
3. Click a test and open its **Output** link to see anything printed with `ITestOutputHelper`.

To run a single problem, type its name in the Test Explorer search box.

Or from the command line:

```bash
dotnet test
dotnet test --filter "CreateGridWithExactlyOnePath"
```

## Running the playground

1. Right-click `LeetCode.Playground` → **Set as Startup Project**.
2. Edit `Program.cs` to call the solution you want.
3. Press **Ctrl+F5**.

## Adding a new problem

1. Add `ProblemName.cs` to `LeetCode.Solutions` with its own namespace.
2. Add `ProblemNameTests.cs` to `LeetCode.Tests`.
3. Run the tests.

## Solved problems

| Problem | Difficulty | Approach |
|---------|------------|----------|
| [Create Grid with Exactly One Path](https://leetcode.com/problems/create-grid-with-exactly-one-path) | Easy | Open the top row and last column, block everything else |
