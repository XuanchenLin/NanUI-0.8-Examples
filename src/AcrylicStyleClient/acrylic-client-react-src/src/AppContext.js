import React, { useContext, useEffect, useReducer } from "react";

const Context = React.createContext();

const actions = {
  ChangeView: "CHANGE_VIEW",
};

const initState = { currentPage: "home" };

const reducer = (state, action) => {
  switch (action.type) {
    case actions.ChangeView:
      return { ...state, currentPage: action.payload };
    default:
      return state;
  }
};

export const ChangeView = (viewName) => {
  const [state, dispatch] = useReducer(reducer, initState);

  useEffect(() => {
    dispatch({ type: actions.ChangeView, payload: viewName });
  });

  return state;
};

export const useAppContext = () => useContext(Context);

const AppContext = (props) => {
  const [state, dispatch] = useReducer(reducer, initState);

  return (
    <Context.Provider value={{ state, dispatch }}>
      {props.children}
    </Context.Provider>
  );
};

export default AppContext;
