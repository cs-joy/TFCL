#include <stdio.h>
#include <stdlib.h>
#include <fcntl.h>
#include <time.h>
#include <sys/stat.h>

const char *filename = "fStatGetFS.c"; //file name - "fStatGetFS.c"

int main(int argc, char *argv[]) {
    struct stat sb;

    int fd = open(filename, O_RDONLY);
    if (fd == -1) {
        perror("open");
        exit(EXIT_FAILURE);
    }

    if (fstat(fd, &sb) == -1) {
        perror("stat");
        exit(EXIT_FAILURE);
    }

    printf("Inode number: %lu\n", sb.st_ino);
    printf("User ID of owner: %u\n", sb.st_uid);
    printf("Group ID of owner: %u\n", sb.st_gid);
    printf("Total file size: %lu bytes\n", sb.st_size);
    printf("Last status change:       %s", ctime(&sb.st_ctime));
    printf("Last file access:         %s", ctime(&sb.st_atime));
    printf("Last file modification:   %s", ctime(&sb.st_mtime));

    close(fd);

    exit(EXIT_SUCCESS);
}