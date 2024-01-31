import axios from 'axios';
import apiClient from "../client";
import { IUser } from "../../interfaces/users";

export const getById = (id: string) => apiClient({
  path: `users/${id}`,
  method: 'GET'
})

export const getByPage = (page: number) => apiClient({
  path: `users?page=${page}`,
  method: 'GET'
})

export const getAll = async (): Promise<{ data: IUser[] }> => {
  const response = await fetch('https://reqres.in/api/users');
  const data = await response.json();
  return { data };
};
export function update(userId: number, user: IUser) {
  return axios.put(`https://reqres.in/api/users/${userId}`, user);
}

