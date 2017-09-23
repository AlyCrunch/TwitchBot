import * as React from "react";
import * as ReactDOM from "react-dom";
import View from "./view";

const state = {
    value: 0,
};

const onDecrement = () => {
    state.value--;
    update();
};

const onIncrement = () => {
    state.value++;
    update();
};

const update = () => {
    ReactDOM.render(
        React.createElement(
            View,
            {
                ...state,
                onDecrement,
                onIncrement,
            },
        ),
        document.body,
    );
};

window.addEventListener("DOMContentLoaded", update);
