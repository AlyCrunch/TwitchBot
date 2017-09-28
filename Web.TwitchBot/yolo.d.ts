declare module 'src/index' {
	import { Action } from 'redux';
	export const reducer: (state: number | undefined, action: Action) => number;

}
