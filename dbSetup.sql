CREATE TABLE IF NOT EXISTS accounts (
    id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
    updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
    name varchar(255) COMMENT 'User Name',
    email varchar(255) UNIQUE COMMENT 'User Email',
    picture varchar(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

CREATE TABLE cryptids (
    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    location VARCHAR(255) NOT NULL,
    eatsPeople BOOL NOT NULL DEFAULT true,
    isHumanoid BOOL NOT NULL DEFAULT false
) default charset utf8mb4 COMMENT '';

-- CREATE
INSERT INTO
  cryptids ( name, location, eatsPeople, isHumanoid )
VALUES
  ('Lagarfljótsormur', 'Lagarfljót, Iceland', false, false)