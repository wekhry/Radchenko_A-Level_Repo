import React, { ReactElement, FC, useState } from "react";
import { TextField, Button, Container } from "@mui/material";
import * as userApi from "../../api/modules/users";
import { IUser } from "../../interfaces/users";

const UpdateUser: FC = (): ReactElement => {
  const [userId, setUserId] = useState<number>(0);
  const [name, setName] = useState<string>("");
  const [job, setJob] = useState<string>("");

  const handleUpdateUser = async () => {
    try {
      const user: IUser = {
        id: userId,
        first_name: name,
        last_name: "",
        avatar: "",
        email: "",
      };
      await userApi.update(userId, user);
      console.log("User updated successfully");
    } catch (e) {
      if (e instanceof Error) {
        console.error(e.message);
        console.error("Failed to update user:", e.message);
      }
    }
  };

  return (
    <Container>
      <TextField
        label="User ID"
        value={userId}
        onChange={(e) => setUserId(Number(e.target.value))}
      />
      <TextField
        label="Name"
        value={name}
        onChange={(e) => setName(e.target.value)}
      />
      <TextField
        label="Job"
        value={job}
        onChange={(e) => setJob(e.target.value)}
      />
      <Button onClick={handleUpdateUser}>Update User</Button>
    </Container>
  );
};

export default UpdateUser;
