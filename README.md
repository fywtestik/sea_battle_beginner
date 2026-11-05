###  Random Placement Algorithm

The project includes an automated fleet layout generator (`PlaceShipsRandomly()`):

1. **Position Validation**: Checks boundary limits ($10 \times 10$ grid) and ensures a mandatory 1-cell buffer zone around previously placed ships.
2. **Iterative Placement**: Randomizes the starting coordinates and orientation (horizontal/vertical) for each ship size, retrying upon collisions.
3. **Guaranteed Fleet Generation**: Places the complete set of ships (1x4, 2x3, 3x2, 4x1) efficiently without deadlocks.
