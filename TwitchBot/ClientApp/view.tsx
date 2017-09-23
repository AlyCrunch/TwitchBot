import * as React from "react";

const App = ({
    value,
    onIncrement,
    onDecrement,
}: {
    value: number,
    onDecrement: (this: void) => void,
    onIncrement: (this: void) => void,
}) => (
    <div>
        <button onClick={onDecrement}>-</button>
        <button onClick={onIncrement}>+</button>
        <span>{value}</span>
    </div>
);

export default App;
