import { createStore, Action } from 'redux';

export const reducer = (state: number, action: Action) => {
    switch (action.type) {
        case 'INCREMENT':
            return state + 1
        case 'DECREMENT':
            return state - 1
        default:
            return state
    }
}

const store = createStore(reducer, 0);

store.subscribe(() => {
    const state = store.getState();
    document.body.innerText = (state||0).toString();
});

const update = () => {
    window.requestAnimationFrame(() => {
        const val = Math.random() % 1;
        store.dispatch({
            type: val > 0.5 ? 'INCREMENT' : 'DECREMENT'
        });
        update();
    });
};

update();
