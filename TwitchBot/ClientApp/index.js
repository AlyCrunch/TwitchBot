var __assign = (this && this.__assign) || Object.assign || function(t) {
    for (var s, i = 1, n = arguments.length; i < n; i++) {
        s = arguments[i];
        for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
            t[p] = s[p];
    }
    return t;
};
import * as React from "react";
import * as ReactDOM from "react-dom";
import View from "./view";
var state = {
    value: 0,
};
var onDecrement = function () {
    state.value--;
    update();
};
var onIncrement = function () {
    state.value++;
    update();
};
var update = function () {
    ReactDOM.render(React.createElement(View, __assign({}, state, { onDecrement: onDecrement,
        onIncrement: onIncrement })), document.body);
};
window.addEventListener("DOMContentLoaded", update);
//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiaW5kZXguanMiLCJzb3VyY2VSb290IjoiIiwic291cmNlcyI6WyJpbmRleC50cyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiOzs7Ozs7OztBQUFBLE9BQU8sS0FBSyxLQUFLLE1BQU0sT0FBTyxDQUFDO0FBQy9CLE9BQU8sS0FBSyxRQUFRLE1BQU0sV0FBVyxDQUFDO0FBQ3RDLE9BQU8sSUFBSSxNQUFNLFFBQVEsQ0FBQztBQUUxQixJQUFNLEtBQUssR0FBRztJQUNWLEtBQUssRUFBRSxDQUFDO0NBQ1gsQ0FBQztBQUVGLElBQU0sV0FBVyxHQUFHO0lBQ2hCLEtBQUssQ0FBQyxLQUFLLEVBQUUsQ0FBQztJQUNkLE1BQU0sRUFBRSxDQUFDO0FBQ2IsQ0FBQyxDQUFDO0FBRUYsSUFBTSxXQUFXLEdBQUc7SUFDaEIsS0FBSyxDQUFDLEtBQUssRUFBRSxDQUFDO0lBQ2QsTUFBTSxFQUFFLENBQUM7QUFDYixDQUFDLENBQUM7QUFFRixJQUFNLE1BQU0sR0FBRztJQUNYLFFBQVEsQ0FBQyxNQUFNLENBQ1gsS0FBSyxDQUFDLGFBQWEsQ0FDZixJQUFJLGVBRUcsS0FBSyxJQUNSLFdBQVcsYUFBQTtRQUNYLFdBQVcsYUFBQSxJQUVsQixFQUNELFFBQVEsQ0FBQyxJQUFJLENBQ2hCLENBQUM7QUFDTixDQUFDLENBQUM7QUFFRixNQUFNLENBQUMsZ0JBQWdCLENBQUMsa0JBQWtCLEVBQUUsTUFBTSxDQUFDLENBQUMiLCJzb3VyY2VzQ29udGVudCI6WyJpbXBvcnQgKiBhcyBSZWFjdCBmcm9tIFwicmVhY3RcIjtcclxuaW1wb3J0ICogYXMgUmVhY3RET00gZnJvbSBcInJlYWN0LWRvbVwiO1xyXG5pbXBvcnQgVmlldyBmcm9tIFwiLi92aWV3XCI7XHJcblxyXG5jb25zdCBzdGF0ZSA9IHtcclxuICAgIHZhbHVlOiAwLFxyXG59O1xyXG5cclxuY29uc3Qgb25EZWNyZW1lbnQgPSAoKSA9PiB7XHJcbiAgICBzdGF0ZS52YWx1ZS0tO1xyXG4gICAgdXBkYXRlKCk7XHJcbn07XHJcblxyXG5jb25zdCBvbkluY3JlbWVudCA9ICgpID0+IHtcclxuICAgIHN0YXRlLnZhbHVlKys7XHJcbiAgICB1cGRhdGUoKTtcclxufTtcclxuXHJcbmNvbnN0IHVwZGF0ZSA9ICgpID0+IHtcclxuICAgIFJlYWN0RE9NLnJlbmRlcihcclxuICAgICAgICBSZWFjdC5jcmVhdGVFbGVtZW50KFxyXG4gICAgICAgICAgICBWaWV3LFxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAuLi5zdGF0ZSxcclxuICAgICAgICAgICAgICAgIG9uRGVjcmVtZW50LFxyXG4gICAgICAgICAgICAgICAgb25JbmNyZW1lbnQsXHJcbiAgICAgICAgICAgIH0sXHJcbiAgICAgICAgKSxcclxuICAgICAgICBkb2N1bWVudC5ib2R5LFxyXG4gICAgKTtcclxufTtcclxuXHJcbndpbmRvdy5hZGRFdmVudExpc3RlbmVyKFwiRE9NQ29udGVudExvYWRlZFwiLCB1cGRhdGUpO1xyXG4iXX0=